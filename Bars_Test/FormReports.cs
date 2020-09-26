using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bars_Test
{
    partial class FormReports : Form
    {
        private Enterprise _enterprise;
        public Enterprise BaseEnterprise { get { return _enterprise; } }
        public FormReports()
        {
            InitializeComponent();
        }
        public FormReports(Enterprise enterprise)
        {
            InitializeComponent();
            _enterprise = enterprise;

            foreach(Filiation elemF in _enterprise.Filiations)
                comboBoxF.Items.Add(elemF.Name);
            if(_enterprise.Filiations.Count != 0)
                comboBoxF.SelectedIndex = 0;
        }


        private void buttonPrintReport_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath.ToString() + "\\Отчеты"))
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Отчеты");

            if (checkBox1.Checked) 
            {
                printReport1(BaseEnterprise);
            }
            if (checkBox2.Checked)
            {
                printReport2(BaseEnterprise);
            }
            if (checkBox3.Checked)
            {
                printReport3(BaseEnterprise);
            }
            if (checkBox4.Checked)
            {
                printReport4(BaseEnterprise);
            }
            if (checkBox5.Checked)
            {
                printReport5(BaseEnterprise);
            }
            if (checkBox6.Checked)
            {
                printReport6(BaseEnterprise);
            }
            if (checkBox7.Checked)
            {
                printReport7(BaseEnterprise);
            }
            if (checkBox8.Checked)
            {
                printReport8(BaseEnterprise);
            }
            if (checkBox9.Checked)
            {
                printReport9(BaseEnterprise);
            }
            MessageBox.Show("Отчеты сформированны.");
        }
        /// <summary>
        /// Список филиалов в алфавитном порядке
        /// </summary>
        private void printReport1(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 1), false, System.Text.Encoding.Default))
                {
                    foreach (Filiation elemF in enterprise.Filiations.OrderBy(x => x.Name))
                        sw.WriteLine(elemF.Name);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Список подразделений в алфавитном порядке
        /// </summary>
        private void printReport2(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 2), false, System.Text.Encoding.Default))
                {
                    foreach (Filiation elemF in enterprise.Filiations)
                    {
                        sw.WriteLine(elemF.Name+":");
                        foreach (Unit elemU in elemF.Units.OrderBy(x => x.Name))
                            sw.WriteLine(elemU.Name);
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Список филиалов в алфавитном порядке с указанием кол-ва работающих сотрудников в филиале
        /// </summary>
        private void printReport3(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 3), false, System.Text.Encoding.Default))
                {
                    int countEmployee = 0;
                    foreach (Filiation elemF in enterprise.Filiations.OrderBy(x => x.Name))
                    {
                        foreach (Unit elemU in elemF.Units)
                            countEmployee += elemU.Employees.Count;

                        sw.WriteLine(elemF.Name+":"+ countEmployee.ToString());
                        countEmployee = 0;
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Расчетный лист за текущий месяц в виде для филиала F и подразделения S (указывается пользователем) 
        /// в виде списка сотрудников в алфавитном порядке с указанием суммы зарплаты
        /// </summary>
        private void printReport4(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 4), false, System.Text.Encoding.Default))
                {
                    if (comboBoxF.SelectedItem != null && comboBoxPodr.SelectedItem != null)
                    {
                        Filiation filial = BaseEnterprise.Filiations.Find(x => x.Name.Contains(comboBoxF.SelectedItem.ToString()));
                        Unit unit = filial.Units.Find(x => x.Name.Contains(comboBoxPodr.SelectedItem.ToString()));

                        foreach (Employee elemE in unit.Employees.OrderBy(x => x.EmployeeFIO.Surname))
                            sw.WriteLine(elemE.EmployeeFIO.Surname + " " 
                                + elemE.EmployeeFIO.Name + " "
                                + elemE.EmployeeFIO.Pathronymic + ": "
                                + elemE.SumSalary);
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Список филиалов в алфавитном порядке с указанием кол-ва работающих сотрудников в филиале 
        /// с группировкой по подразделениям.
        /// </summary>
        private void printReport5(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 5), false, System.Text.Encoding.Default))
                {
                    foreach (Filiation elemF in enterprise.Filiations.OrderBy(x => x.Name))
                    {
                        sw.WriteLine(elemF.Name + ":");
                        foreach (Unit elemU in elemF.Units)
                          sw.WriteLine(elemU.Name + ":" + elemU.Employees.Count + " чел");
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Список филиалов с указанием средней зарплаты в филиале
        /// </summary>
        private void printReport6(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 6), false, System.Text.Encoding.Default))
                {
                    int countEmployee = 0;
                    decimal sumSalary = 0;
                    foreach (Filiation elemF in enterprise.Filiations)
                    {
                        foreach (Unit elemU in elemF.Units)
                        { 
                            countEmployee += elemU.Employees.Count;
                            foreach (Employee elemE in elemU.Employees)
                                sumSalary += elemE.SumSalary; 
                        }
                        if(sumSalary !=0 && countEmployee != 0)
                            sw.WriteLine(elemF.Name + ":" + sumSalary/countEmployee);
                        countEmployee = 0;
                        sumSalary = 0;
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Список сотрудников, размер зарплаты в текущем месяце которых > X (задается пользователем)
        /// </summary>
        private void printReport7(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 7), false, System.Text.Encoding.Default))
                {
                    decimal xSalary = decimal.Parse(textBoxSalary.Text);
                    foreach (Filiation elemF in enterprise.Filiations.OrderBy(x => x.Name))
                    {
                        foreach (Unit elemU in elemF.Units)
                        {
                            foreach (Employee elemE in elemU.Employees)
                                if(xSalary < elemE.Salary)
                                    sw.WriteLine(elemE.EmployeeFIO.Surname + " "
                                        + elemE.EmployeeFIO.Name + " "
                                        + elemE.EmployeeFIO.Pathronymic);
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Список сотрудников с фиксированной месячной оплатой, которые в текущем  месяце отработали
        /// все требуемые часы согласно трудовому календарю.
        /// </summary>
        private void printReport8(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 8), false, System.Text.Encoding.Default))
                {
                    foreach (Filiation elemF in enterprise.Filiations.OrderBy(x => x.Name))
                    {
                        foreach (Unit elemU in elemF.Units)
                        {
                            foreach (Employee elemE in elemU.Employees)
                                if (elemE.Time == 150)
                                    sw.WriteLine(elemE.EmployeeFIO.Surname +" "
                                        + elemE.EmployeeFIO.Name +" "
                                        + elemE.EmployeeFIO.Pathronymic);
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        /// <summary>
        /// Список N (задается пользователем) сотрудников с наибольшим размером зарплаты в текущем месяце
        /// </summary>
        private void printReport9(Enterprise enterprise)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(string.Format(Application.StartupPath.ToString() + "\\Отчеты\\{0}.txt", 9), false, System.Text.Encoding.Default))
                {
                    int countEmployee = Int32.Parse(textBoxN.Text);
                    List<Employee> allListEmployees = new List<Employee>();
                    foreach (Filiation elemF in enterprise.Filiations)
                    {
                        foreach (Unit elemU in elemF.Units)
                        {
                            foreach (Employee elemE in elemU.Employees)
                                allListEmployees.Add(elemE);
                        }
                    }
                    allListEmployees.GroupBy(x => x.SumSalary);

                    for (int i = 0; i < countEmployee; i++)
                        sw.WriteLine(allListEmployees[i].EmployeeFIO.Surname + " "
                                    + allListEmployees[i].EmployeeFIO.Name + " "
                                    + allListEmployees[i].EmployeeFIO.Pathronymic);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void comboBoxF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filiation filial = BaseEnterprise.Filiations.Find(x => x.Name.Contains(comboBoxF.SelectedItem.ToString()));
            comboBoxPodr.Items.Clear();
            foreach (Unit elem in filial.Units) 
            {
                comboBoxPodr.Items.Add(elem.Name);
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

        private void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
