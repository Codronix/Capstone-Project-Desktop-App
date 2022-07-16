namespace Capstone_Project
{
    partial class frmAddEmployee
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModeOfPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateHired = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(110, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "REGISTER EMPLOYEE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 338);
            this.panel1.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateHired);
            this.groupBox1.Controls.Add(this.txtModeOfPay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpBirthdate);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.cbPosition);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // txtModeOfPay
            // 
            this.txtModeOfPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeOfPay.Location = new System.Drawing.Point(109, 179);
            this.txtModeOfPay.Name = "txtModeOfPay";
            this.txtModeOfPay.ReadOnly = true;
            this.txtModeOfPay.Size = new System.Drawing.Size(131, 22);
            this.txtModeOfPay.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mode of Pay:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CustomFormat = "MM/dd/yyyy";
            this.dtpBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(9, 119);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(131, 22);
            this.dtpBirthdate.TabIndex = 52;
            this.dtpBirthdate.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(336, 298);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 28);
            this.btnRegister.TabIndex = 51;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownHeight = 70;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.IntegralHeight = false;
            this.cbPosition.Location = new System.Drawing.Point(109, 151);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(131, 24);
            this.cbPosition.TabIndex = 49;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Date Hired:";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(109, 205);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(131, 22);
            this.txtSalary.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Salary:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Position:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(286, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 22);
            this.txtAddress.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Address:";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(146, 119);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(134, 22);
            this.txtContact.TabIndex = 41;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Birthdate:";
            // 
            // txtMI
            // 
            this.txtMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.Location = new System.Drawing.Point(146, 75);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(134, 22);
            this.txtMI.TabIndex = 37;
            this.txtMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMI_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "MI:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(286, 75);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(131, 22);
            this.txtSurname.TabIndex = 35;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Surname:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(9, 75);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 22);
            this.txtFirstName.TabIndex = 33;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "First Name:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(113, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(304, 22);
            this.txtID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Employee ID:";
            // 
            // dtpDateHired
            // 
            this.dtpDateHired.CustomFormat = "MM/dd/yyyy";
            this.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateHired.Location = new System.Drawing.Point(109, 233);
            this.dtpDateHired.Name = "dtpDateHired";
            this.dtpDateHired.Size = new System.Drawing.Size(131, 22);
            this.dtpDateHired.TabIndex = 58;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(462, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Employee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModeOfPay;
        private System.Windows.Forms.DateTimePicker dtpDateHired;
    }
}