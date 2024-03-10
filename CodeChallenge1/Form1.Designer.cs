namespace CodeChallenge1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            cmbPosition = new ComboBox();
            btnAddEmployee = new Button();
            btnGenerateReport = new Button();
            lstReports = new ListBox();
            lstEmployees = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtMonday = new TextBox();
            label6 = new Label();
            txtTuesday = new TextBox();
            label7 = new Label();
            txtWednesday = new TextBox();
            label8 = new Label();
            txtThursday = new TextBox();
            label9 = new Label();
            txtFriday = new TextBox();
            label10 = new Label();
            txtSaturday = new TextBox();
            label11 = new Label();
            txtSunday = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Regular", "Manager", "Nightshift" });
            cmbPosition.Location = new Point(170, 142);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(156, 23);
            cmbPosition.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(600, 522);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(151, 33);
            btnAddEmployee.TabIndex = 10;
            btnAddEmployee.Text = "Add Employee Hours";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click_1;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(922, 522);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(151, 33);
            btnGenerateReport.TabIndex = 11;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click_1;
            // 
            // lstReports
            // 
            lstReports.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstReports.FormattingEnabled = true;
            lstReports.ItemHeight = 20;
            lstReports.Location = new Point(600, 254);
            lstReports.Name = "lstReports";
            lstReports.Size = new Size(473, 184);
            lstReports.TabIndex = 14;
            // 
            // lstEmployees
            // 
            lstEmployees.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 20;
            lstEmployees.Location = new Point(600, 94);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(473, 104);
            lstEmployees.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 94);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 145);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 11;
            label3.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 274);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 14;
            label5.Text = "Monday";
            // 
            // txtMonday
            // 
            txtMonday.Location = new Point(170, 271);
            txtMonday.Name = "txtMonday";
            txtMonday.Size = new Size(67, 23);
            txtMonday.TabIndex = 3;
            txtMonday.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 318);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 16;
            label6.Text = "Tuesday";
            // 
            // txtTuesday
            // 
            txtTuesday.Location = new Point(170, 315);
            txtTuesday.Name = "txtTuesday";
            txtTuesday.Size = new Size(67, 23);
            txtTuesday.TabIndex = 4;
            txtTuesday.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 364);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 18;
            label7.Text = "Wednesday";
            // 
            // txtWednesday
            // 
            txtWednesday.Location = new Point(170, 361);
            txtWednesday.Name = "txtWednesday";
            txtWednesday.Size = new Size(67, 23);
            txtWednesday.TabIndex = 5;
            txtWednesday.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 410);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 20;
            label8.Text = "Thursday";
            // 
            // txtThursday
            // 
            txtThursday.Location = new Point(170, 407);
            txtThursday.Name = "txtThursday";
            txtThursday.Size = new Size(67, 23);
            txtThursday.TabIndex = 6;
            txtThursday.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 452);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 22;
            label9.Text = "Friday";
            // 
            // txtFriday
            // 
            txtFriday.Location = new Point(170, 449);
            txtFriday.Name = "txtFriday";
            txtFriday.Size = new Size(67, 23);
            txtFriday.TabIndex = 7;
            txtFriday.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 494);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 24;
            label10.Text = "Saturday";
            // 
            // txtSaturday
            // 
            txtSaturday.Location = new Point(170, 491);
            txtSaturday.Name = "txtSaturday";
            txtSaturday.Size = new Size(67, 23);
            txtSaturday.TabIndex = 8;
            txtSaturday.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 535);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 26;
            label11.Text = "Sunday";
            // 
            // txtSunday
            // 
            txtSunday.Location = new Point(170, 532);
            txtSunday.Name = "txtSunday";
            txtSunday.Size = new Size(67, 23);
            txtSunday.TabIndex = 9;
            txtSunday.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(51, 230);
            label12.Name = "label12";
            label12.Size = new Size(119, 21);
            label12.TabIndex = 27;
            label12.Text = "Hours Worked";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(53, 53);
            label13.Name = "label13";
            label13.Size = new Size(143, 21);
            label13.TabIndex = 28;
            label13.Text = "Employee Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(600, 230);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 29;
            label2.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 644);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSunday);
            Controls.Add(label10);
            Controls.Add(txtSaturday);
            Controls.Add(label9);
            Controls.Add(txtFriday);
            Controls.Add(label8);
            Controls.Add(txtThursday);
            Controls.Add(label7);
            Controls.Add(txtWednesday);
            Controls.Add(label6);
            Controls.Add(txtTuesday);
            Controls.Add(label5);
            Controls.Add(txtMonday);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstEmployees);
            Controls.Add(lstReports);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnAddEmployee);
            Controls.Add(cmbPosition);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private ComboBox cmbPosition;
        private Button btnAddEmployee;
        private Button btnGenerateReport;
        private ListBox lstReports;
        private ListBox lstEmployees;
        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox txtMonday;
        private Label label6;
        private TextBox txtTuesday;
        private Label label7;
        private TextBox txtWednesday;
        private Label label8;
        private TextBox txtThursday;
        private Label label9;
        private TextBox txtFriday;
        private Label label10;
        private TextBox txtSaturday;
        private Label label11;
        private TextBox txtSunday;
        private Label label12;
        private Label label13;
        private Label label2;
    }
}
