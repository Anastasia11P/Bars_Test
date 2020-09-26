namespace Bars_Test
{
    partial class FormReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxF = new System.Windows.Forms.ComboBox();
            this.comboBoxPodr = new System.Windows.Forms.ComboBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonPrintReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(319, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1. Список филиалов в алфавитном порядке";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(356, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "2. Список подразделений в алфавитном порядке";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(12, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(344, 62);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "3. Список филиалов в алфавитном порядке с указанием кол-ва работающих сотрудников" +
    " в филиале";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(12, 144);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(344, 96);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "4. Расчетный лист за текущий месяц в виде для филиала F и подразделения S (указыв" +
    "ается пользователем) в виде списка сотрудников в алфавитном порядке с указанием " +
    "суммы зарплаты";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(12, 246);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(344, 39);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "5.\tСписок филиалов в алфавитном порядке с указанием кол-ва работающих сотрудников" +
    " в филиале с группировкой по подразделениям.";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(12, 291);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(344, 39);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "6. Список филиалов с указанием средней зарплаты в филиале";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(12, 336);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(356, 70);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "7. Список сотрудников, размер зарплаты в текущем месяце которых > X (задается пол" +
    "ьзователем)";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Location = new System.Drawing.Point(12, 402);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(315, 66);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "8. Список сотрудников с фиксированной месячной оплатой, которые в текущем  месяце" +
    " отработали все требуемые часы согласно трудовому календарю.";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.Location = new System.Drawing.Point(12, 462);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(344, 69);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "9. Список N (задается пользователем) сотрудников с наибольшим размером зарплаты в" +
    " текущем месяце";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Филиал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подразделение:";
            // 
            // comboBoxF
            // 
            this.comboBoxF.FormattingEnabled = true;
            this.comboBoxF.Location = new System.Drawing.Point(433, 153);
            this.comboBoxF.Name = "comboBoxF";
            this.comboBoxF.Size = new System.Drawing.Size(272, 24);
            this.comboBoxF.TabIndex = 11;
            this.comboBoxF.SelectedIndexChanged += new System.EventHandler(this.comboBoxF_SelectedIndexChanged);
            // 
            // comboBoxPodr
            // 
            this.comboBoxPodr.FormattingEnabled = true;
            this.comboBoxPodr.Location = new System.Drawing.Point(478, 192);
            this.comboBoxPodr.Name = "comboBoxPodr";
            this.comboBoxPodr.Size = new System.Drawing.Size(227, 24);
            this.comboBoxPodr.TabIndex = 12;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSalary.Location = new System.Drawing.Point(344, 356);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(53, 27);
            this.textBoxSalary.TabIndex = 13;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(344, 481);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(53, 27);
            this.textBoxN.TabIndex = 14;
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            // 
            // buttonPrintReport
            // 
            this.buttonPrintReport.Location = new System.Drawing.Point(520, 451);
            this.buttonPrintReport.Name = "buttonPrintReport";
            this.buttonPrintReport.Size = new System.Drawing.Size(213, 58);
            this.buttonPrintReport.TabIndex = 15;
            this.buttonPrintReport.Text = "Получить отчеты";
            this.buttonPrintReport.UseVisualStyleBackColor = true;
            this.buttonPrintReport.Click += new System.EventHandler(this.buttonPrintReport_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 543);
            this.Controls.Add(this.buttonPrintReport);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.comboBoxPodr);
            this.Controls.Add(this.comboBoxF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormReports";
            this.Text = "Отчеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxF;
        private System.Windows.Forms.ComboBox comboBoxPodr;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonPrintReport;
    }
}