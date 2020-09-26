using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bars_Test
{
    public partial class Form1 : Form
    {
        private Enterprise enterpriseBase;
        public Form1()
        {
            InitializeComponent();
            enterpriseBase = new Enterprise();
            comboBoxType.Items.Add("Фиксированная ежемесячная оплата");
            comboBoxType.Items.Add("Почасовая оплата");
            comboBoxType.SelectedIndex = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    XDocument doc = XDocument.Load(openFile.FileName);
                    if (doc.Declaration.Encoding.Equals("utf-8") || doc.Declaration.Encoding.Equals("UTF-8"))
                    {
                        saveToolStripMenuItem.Enabled = true;

                        XElement enterprise = doc.Root;
                        enterpriseBase = new Enterprise();
                        this.Text = enterprise.Attribute("Наименование").Value;
                        if (enterprise.HasElements)
                        {
                            foreach (XElement xEnterprise in enterprise.Elements())
                            {
                                Filiation filiation = new Filiation();
                                filiation.Name = xEnterprise.Attribute("Наименование").Value;
                                filiation.Address = xEnterprise.Attribute("Адрес").Value;

                                foreach (XElement xUnit in xEnterprise.Elements())
                                {
                                    Unit unit = new Unit();
                                    unit.Name = xUnit.Attribute("Наименование").Value;
                                    unit.Filiation = filiation;

                                    foreach (XElement xEmployee in xUnit.Elements())
                                    {
                                        Employee employee = new Employee();
                                        employee.EmployeeFIO.Name = xEmployee.Attribute("Имя").Value;
                                        employee.EmployeeFIO.Surname = xEmployee.Attribute("Фамилия").Value;
                                        employee.EmployeeFIO.Pathronymic = xEmployee.Attribute("Отчество").Value;
                                        employee.TypeSalary = xEmployee.Attribute("ТипЗП").Value; ;
                                        employee.Salary = decimal.Parse(xEmployee.Attribute("ЗП").Value, new NumberFormatInfo { NumberDecimalSeparator = "." });
                                        employee.Time = decimal.Parse(xEmployee.Attribute("Часы").Value, new NumberFormatInfo { NumberDecimalSeparator = "." });
                                        employee.Unit = unit;
                                        unit.Employees.Add(employee);
                                    }
                                    filiation.Units.Add(unit);
                                }
                                enterpriseBase.Filiations.Add(filiation);
                            }
                            ShowFiliations();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Загружаемая база повреждена");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Загружаемая база повреждена");
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enterpriseBase != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {

                    XDocument doc = new XDocument();
                    XElement enterprise = new XElement("Предприятие", new XAttribute("Наименование", this.Text));
                    foreach (Filiation elemFiliation in enterpriseBase.Filiations)
                    {
                        XElement filiation = new XElement("Филиал",
                            new XAttribute("Наименование", elemFiliation.Name),
                            new XAttribute("Адрес", elemFiliation.Address));
                        foreach (Unit elemUnion in elemFiliation.Units)
                        {
                            XElement unit = new XElement("Подразделение",
                            new XAttribute("Наименование", elemUnion.Name));

                            foreach (Employee elemEmployee in elemUnion.Employees)
                            {
                                XElement employee = new XElement("Сотрудник",
                                new XAttribute("Фамилия", elemEmployee.EmployeeFIO.Surname),
                                new XAttribute("Имя", elemEmployee.EmployeeFIO.Name),
                                new XAttribute("Отчество", elemEmployee.EmployeeFIO.Pathronymic),
                                new XAttribute("ТипЗП", elemEmployee.TypeSalary),
                                new XAttribute("ЗП", elemEmployee.Salary),
                                new XAttribute("Часы", elemEmployee.Time));

                                unit.Add(employee);
                            }
                            filiation.Add(unit);
                        }
                        enterprise.Add(filiation);
                    }

                    doc.Add(enterprise);
                    doc.Save(saveFile.FileName);
                    MessageBox.Show("База сохранена.");
                }
            }
        }
        private void button_AddFiliation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameFiliation.Text))
            {
                if (enterpriseBase.Filiations.Find(x => x.Name == textBoxNameFiliation.Text 
                                                        && x.Address == textBoxAddressFiliation.Text) !=null)
                {
                    MessageBox.Show("Информация о данном филиале уже внесена.");
                    return;
                }

                Filiation filiation = new Filiation();
                filiation.Name = textBoxNameFiliation.Text;
                filiation.Address = textBoxAddressFiliation.Text;

                enterpriseBase.Filiations.Add(filiation);
                ShowFiliations();
            }
        }

        private void button_AddUnit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameUnit.Text) && listBoxFiliations.SelectedIndex != -1)
            {
                Filiation filiation = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));

                if (filiation.Units.Find(x => x.Name == textBoxNameUnit.Text) != null)
                {
                    MessageBox.Show("Информация о данном подразделении уже внесена.");
                    return;
                }

                Unit unit = new Unit();
                unit.Name = textBoxNameUnit.Text;
                unit.Filiation = filiation;
                unit.Filiation.Units.Add(unit);

                ShowUnits(unit.Filiation);
            }
            else MessageBox.Show("Необходимо выбрать филиал и заполнить поле Наименование.");
        }

        private void button_DeleteFiliation_Click(object sender, EventArgs e)
        {
            if (listBoxFiliations.SelectedItem != null)
            {
                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                enterpriseBase.Filiations.Remove(filial);
            }
            ShowFiliations();
        }

        private void button_DeleteUnit_Click(object sender, EventArgs e)
        {
            if (listBoxFiliations.SelectedItem != null && listBoxUnits.SelectedItem != null)
            {
                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                Unit unit = filial.Units.Find(x => x.Name.Contains(listBoxUnits.SelectedItem.ToString()));
                filial.Units.Remove(unit);
                ShowUnits(filial);
            }
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text)
                && !string.IsNullOrEmpty(textBoxSurname.Text)
                && !string.IsNullOrEmpty(textBoxPathronymic.Text)
                && !string.IsNullOrEmpty(textBoxSalary.Text)
                && !string.IsNullOrEmpty(textBoxCountHour.Text)
                && listBoxUnits.SelectedIndex != -1)
            {
                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                Unit unit = filial.Units.Find(x => x.Name.Contains(listBoxUnits.SelectedItem.ToString()));

                if (unit.Employees.Find(x => x.EmployeeFIO.Name == textBoxName.Text
                                            && x.EmployeeFIO.Surname == textBoxSurname.Text
                                            && x.EmployeeFIO.Pathronymic == textBoxPathronymic.Text) != null)
                {
                    MessageBox.Show("Информация о данном сотруднике уже внесена.");
                    return;
                }



                Employee employee = new Employee();
                employee.EmployeeFIO.Name = textBoxName.Text;
                employee.EmployeeFIO.Surname = textBoxSurname.Text;
                employee.EmployeeFIO.Pathronymic = textBoxPathronymic.Text;
                employee.TypeSalary = comboBoxType.SelectedItem.ToString();
                employee.Salary = decimal.Parse(textBoxSalary.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
                employee.Time = decimal.Parse(textBoxCountHour.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });

                unit.Employees.Add(employee);
                listBoxEmployee.Items.Clear();
                ShowEmployee(unit);
            }
            else MessageBox.Show("Выберите подразделение.");
        }

        private void button_DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxFiliations.SelectedItem != null
                && listBoxUnits.SelectedItem != null
                && listBoxEmployee.SelectedItem != null)
            {
                string fio = listBoxEmployee.SelectedItem.ToString();
                string[] masFIO = fio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                Unit unit = filial.Units.Find(x => x.Name.Contains(listBoxUnits.SelectedItem.ToString()));
                Employee employee = unit.Employees.Find(x => x.EmployeeFIO.Name.Contains(masFIO[0])
                                                            && x.EmployeeFIO.Surname.Contains(masFIO[1])
                                                            && x.EmployeeFIO.Pathronymic.Contains(masFIO[2]));
                unit.Employees.Remove(employee);
                listBoxEmployee.Items.Clear();
                ShowEmployee(unit);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text)
                && !string.IsNullOrEmpty(textBoxSurname.Text)
                && !string.IsNullOrEmpty(textBoxPathronymic.Text)
                && listBoxUnits.SelectedIndex != -1)
            {
                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                Unit unit = filial.Units.Find(x => x.Name.Contains(listBoxUnits.SelectedItem.ToString()));
                Employee employee = unit.Employees.Find(x => 
                (x.EmployeeFIO.Name.Contains(textBoxName.Text)) 
                && x.EmployeeFIO.Surname.Contains(textBoxSurname.Text)
                && x.EmployeeFIO.Pathronymic.Contains(textBoxPathronymic.Text)
                );
                if (employee != null)
                {
                    employee.TypeSalary = comboBoxType.SelectedItem.ToString();
                    employee.Salary = decimal.Parse(textBoxSalary.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
                    employee.Time = decimal.Parse(textBoxCountHour.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
                }
                listBoxEmployee.Items.Clear();
                ShowEmployee(unit);
            }
            else MessageBox.Show("Необходимо заполнить все поля и выбрать подразделение.");
        }

        private void ShowFiliations()
        {
            listBoxFiliations.Items.Clear();
            foreach (Filiation elem in enterpriseBase.Filiations)
            {
                listBoxFiliations.Items.Add(elem.Name);
                ShowUnits(elem);
            }
        }
        private void ShowUnits(Filiation filiation)
        {
            listBoxUnits.Items.Clear();
            listBoxEmployee.Items.Clear();
            foreach (Unit elem in filiation.Units)
            {
                listBoxUnits.Items.Add(elem.Name);
                ShowEmployee(elem);
            }
        }
        private void ShowEmployee(Unit unit)
        {
            foreach (Employee elem in unit.Employees)
            {
                listBoxEmployee.Items.Add(elem.EmployeeFIO.Name + " " + elem.EmployeeFIO.Surname + " " + elem.EmployeeFIO.Pathronymic);
            }
        }

        private void textBoxCountHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) 
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports reports = new FormReports(enterpriseBase);
            reports.ShowDialog();
        }

        private void listBoxFiliations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiliations.SelectedItem != null)
            {
                Filiation filiation = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                textBoxNameFiliation.Text = filiation.Name;
                textBoxAddressFiliation.Text = filiation.Address;
                ShowUnits(filiation);
            }
        }
        private void listBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiliations.SelectedItem != null && listBoxUnits.SelectedItem != null)
            {
                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                Unit unit = filial.Units.Find(x => x.Name.Contains(listBoxUnits.SelectedItem.ToString()));
                textBoxNameUnit.Text = unit.Name;
                listBoxEmployee.Items.Clear();
                ShowEmployee(unit);
            }
        }
        private void listBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiliations.SelectedItem != null
                && listBoxUnits.SelectedItem != null
                && listBoxEmployee.SelectedItem != null)
            {
                string fio = listBoxEmployee.SelectedItem.ToString();
                string[] masFIO = fio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Filiation filial = enterpriseBase.Filiations.Find(x => x.Name.Contains(listBoxFiliations.SelectedItem.ToString()));
                Unit unit = filial.Units.Find(x => x.Name.Contains(listBoxUnits.SelectedItem.ToString()));
                Employee employee = unit.Employees.Find(x =>
                x.EmployeeFIO.Name.Contains(masFIO[0])
                && x.EmployeeFIO.Surname.Contains(masFIO[1])
                && x.EmployeeFIO.Pathronymic.Contains(masFIO[2])
                );
                if (employee != null)
                {
                    textBoxName.Text = employee.EmployeeFIO.Name;
                    textBoxSurname.Text = employee.EmployeeFIO.Surname;
                    textBoxPathronymic.Text = employee.EmployeeFIO.Pathronymic;
                    textBoxSalary.Text = employee.Salary.ToString();
                    textBoxCountHour.Text = employee.Time.ToString();
                    if (employee.TypeSalary == "Почасовая оплата")
                        comboBoxType.SelectedIndex = 1;
                    else
                        comboBoxType.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show("Выберите Филиал, Подразделение и Сотрудника(данные о котором необходимо изменить)");
        }
    }
}
