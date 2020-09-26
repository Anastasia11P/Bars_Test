namespace Bars_Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_AddFiliation = new System.Windows.Forms.Button();
            this.listBoxFiliations = new System.Windows.Forms.ListBox();
            this.listBoxUnits = new System.Windows.Forms.ListBox();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.textBoxNameFiliation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DeleteFiliation = new System.Windows.Forms.Button();
            this.button_DeleteUnit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameUnit = new System.Windows.Forms.TextBox();
            this.button_AddUnit = new System.Windows.Forms.Button();
            this.button_DeleteEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddressFiliation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPathronymic = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCountHour = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddFiliation
            // 
            this.button_AddFiliation.Image = ((System.Drawing.Image)(resources.GetObject("button_AddFiliation.Image")));
            this.button_AddFiliation.Location = new System.Drawing.Point(281, 59);
            this.button_AddFiliation.Name = "button_AddFiliation";
            this.button_AddFiliation.Size = new System.Drawing.Size(72, 55);
            this.button_AddFiliation.TabIndex = 0;
            this.button_AddFiliation.UseVisualStyleBackColor = true;
            this.button_AddFiliation.Click += new System.EventHandler(this.button_AddFiliation_Click);
            // 
            // listBoxFiliations
            // 
            this.listBoxFiliations.FormattingEnabled = true;
            this.listBoxFiliations.ItemHeight = 16;
            this.listBoxFiliations.Location = new System.Drawing.Point(12, 139);
            this.listBoxFiliations.Name = "listBoxFiliations";
            this.listBoxFiliations.Size = new System.Drawing.Size(432, 100);
            this.listBoxFiliations.TabIndex = 1;
            this.listBoxFiliations.SelectedIndexChanged += new System.EventHandler(this.listBoxFiliations_SelectedIndexChanged);
            // 
            // listBoxUnits
            // 
            this.listBoxUnits.FormattingEnabled = true;
            this.listBoxUnits.ItemHeight = 16;
            this.listBoxUnits.Location = new System.Drawing.Point(12, 313);
            this.listBoxUnits.Name = "listBoxUnits";
            this.listBoxUnits.Size = new System.Drawing.Size(432, 100);
            this.listBoxUnits.TabIndex = 2;
            this.listBoxUnits.SelectedIndexChanged += new System.EventHandler(this.listBoxUnits_SelectedIndexChanged);
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 16;
            this.listBoxEmployee.Location = new System.Drawing.Point(471, 233);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(482, 180);
            this.listBoxEmployee.TabIndex = 3;
            this.listBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployee_SelectedIndexChanged);
            // 
            // textBoxNameFiliation
            // 
            this.textBoxNameFiliation.Location = new System.Drawing.Point(15, 59);
            this.textBoxNameFiliation.Name = "textBoxNameFiliation";
            this.textBoxNameFiliation.Size = new System.Drawing.Size(260, 22);
            this.textBoxNameFiliation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование филиала:";
            // 
            // button_DeleteFiliation
            // 
            this.button_DeleteFiliation.Image = ((System.Drawing.Image)(resources.GetObject("button_DeleteFiliation.Image")));
            this.button_DeleteFiliation.Location = new System.Drawing.Point(375, 59);
            this.button_DeleteFiliation.Name = "button_DeleteFiliation";
            this.button_DeleteFiliation.Size = new System.Drawing.Size(72, 55);
            this.button_DeleteFiliation.TabIndex = 6;
            this.button_DeleteFiliation.UseVisualStyleBackColor = true;
            this.button_DeleteFiliation.Click += new System.EventHandler(this.button_DeleteFiliation_Click);
            // 
            // button_DeleteUnit
            // 
            this.button_DeleteUnit.Image = ((System.Drawing.Image)(resources.GetObject("button_DeleteUnit.Image")));
            this.button_DeleteUnit.Location = new System.Drawing.Point(372, 254);
            this.button_DeleteUnit.Name = "button_DeleteUnit";
            this.button_DeleteUnit.Size = new System.Drawing.Size(72, 53);
            this.button_DeleteUnit.TabIndex = 10;
            this.button_DeleteUnit.UseVisualStyleBackColor = true;
            this.button_DeleteUnit.Click += new System.EventHandler(this.button_DeleteUnit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Наименование подразделения:";
            // 
            // textBoxNameUnit
            // 
            this.textBoxNameUnit.Location = new System.Drawing.Point(12, 272);
            this.textBoxNameUnit.Name = "textBoxNameUnit";
            this.textBoxNameUnit.Size = new System.Drawing.Size(260, 22);
            this.textBoxNameUnit.TabIndex = 8;
            // 
            // button_AddUnit
            // 
            this.button_AddUnit.Image = ((System.Drawing.Image)(resources.GetObject("button_AddUnit.Image")));
            this.button_AddUnit.Location = new System.Drawing.Point(278, 254);
            this.button_AddUnit.Name = "button_AddUnit";
            this.button_AddUnit.Size = new System.Drawing.Size(72, 53);
            this.button_AddUnit.TabIndex = 7;
            this.button_AddUnit.UseVisualStyleBackColor = true;
            this.button_AddUnit.Click += new System.EventHandler(this.button_AddUnit_Click);
            // 
            // button_DeleteEmployee
            // 
            this.button_DeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("button_DeleteEmployee.Image")));
            this.button_DeleteEmployee.Location = new System.Drawing.Point(879, 101);
            this.button_DeleteEmployee.Name = "button_DeleteEmployee";
            this.button_DeleteEmployee.Size = new System.Drawing.Size(72, 52);
            this.button_DeleteEmployee.TabIndex = 14;
            this.button_DeleteEmployee.UseVisualStyleBackColor = true;
            this.button_DeleteEmployee.Click += new System.EventHandler(this.button_DeleteEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Фамилия:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(469, 78);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(173, 22);
            this.textBoxSurname.TabIndex = 12;
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("button_AddEmployee.Image")));
            this.button_AddEmployee.Location = new System.Drawing.Point(879, 45);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(72, 50);
            this.button_AddEmployee.TabIndex = 11;
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.reportToolStripMenuItem.Text = "Отчеты";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Адрес:";
            // 
            // textBoxAddressFiliation
            // 
            this.textBoxAddressFiliation.Location = new System.Drawing.Point(12, 106);
            this.textBoxAddressFiliation.Name = "textBoxAddressFiliation";
            this.textBoxAddressFiliation.Size = new System.Drawing.Size(260, 22);
            this.textBoxAddressFiliation.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(469, 132);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 22);
            this.textBoxName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Отчество:";
            // 
            // textBoxPathronymic
            // 
            this.textBoxPathronymic.Location = new System.Drawing.Point(469, 189);
            this.textBoxPathronymic.Name = "textBoxPathronymic";
            this.textBoxPathronymic.Size = new System.Drawing.Size(173, 22);
            this.textBoxPathronymic.TabIndex = 20;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(879, 159);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(72, 50);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Размер з/п:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(671, 135);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(173, 22);
            this.textBoxSalary.TabIndex = 25;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Тип з/п:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(671, 80);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(173, 24);
            this.comboBoxType.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Отработанные часы (мес.):";
            // 
            // textBoxCountHour
            // 
            this.textBoxCountHour.Location = new System.Drawing.Point(671, 187);
            this.textBoxCountHour.Name = "textBoxCountHour";
            this.textBoxCountHour.Size = new System.Drawing.Size(173, 22);
            this.textBoxCountHour.TabIndex = 28;
            this.textBoxCountHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountHour_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 434);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCountHour);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPathronymic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddressFiliation);
            this.Controls.Add(this.button_DeleteEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.button_AddEmployee);
            this.Controls.Add(this.button_DeleteUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameUnit);
            this.Controls.Add(this.button_AddUnit);
            this.Controls.Add(this.button_DeleteFiliation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameFiliation);
            this.Controls.Add(this.listBoxEmployee);
            this.Controls.Add(this.listBoxUnits);
            this.Controls.Add(this.listBoxFiliations);
            this.Controls.Add(this.button_AddFiliation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Барс";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddFiliation;
        private System.Windows.Forms.ListBox listBoxFiliations;
        private System.Windows.Forms.ListBox listBoxUnits;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.TextBox textBoxNameFiliation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteFiliation;
        private System.Windows.Forms.Button button_DeleteUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameUnit;
        private System.Windows.Forms.Button button_AddUnit;
        private System.Windows.Forms.Button button_DeleteEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddressFiliation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPathronymic;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCountHour;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}

