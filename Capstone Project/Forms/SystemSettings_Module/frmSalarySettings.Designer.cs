
namespace Capstone_Project.Forms.SystemSettings_Module
{
    partial class frmSalarySettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemovePos = new System.Windows.Forms.Button();
            this.btnSet_Pos_Settings = new System.Windows.Forms.Button();
            this.cbModeOfPay = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 155);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemovePos);
            this.groupBox1.Controls.Add(this.btnSet_Pos_Settings);
            this.groupBox1.Controls.Add(this.cbModeOfPay);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPosition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Positions and Salary Settings";
            // 
            // btnRemovePos
            // 
            this.btnRemovePos.BackColor = System.Drawing.Color.Red;
            this.btnRemovePos.FlatAppearance.BorderSize = 0;
            this.btnRemovePos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePos.ForeColor = System.Drawing.Color.White;
            this.btnRemovePos.Location = new System.Drawing.Point(224, 108);
            this.btnRemovePos.Name = "btnRemovePos";
            this.btnRemovePos.Size = new System.Drawing.Size(76, 24);
            this.btnRemovePos.TabIndex = 7;
            this.btnRemovePos.Text = "Remove";
            this.btnRemovePos.UseVisualStyleBackColor = false;
            this.btnRemovePos.Click += new System.EventHandler(this.btnRemovePos_Click);
            // 
            // btnSet_Pos_Settings
            // 
            this.btnSet_Pos_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSet_Pos_Settings.FlatAppearance.BorderSize = 0;
            this.btnSet_Pos_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet_Pos_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet_Pos_Settings.ForeColor = System.Drawing.Color.White;
            this.btnSet_Pos_Settings.Location = new System.Drawing.Point(142, 108);
            this.btnSet_Pos_Settings.Name = "btnSet_Pos_Settings";
            this.btnSet_Pos_Settings.Size = new System.Drawing.Size(76, 24);
            this.btnSet_Pos_Settings.TabIndex = 6;
            this.btnSet_Pos_Settings.Text = "Set";
            this.btnSet_Pos_Settings.UseVisualStyleBackColor = false;
            this.btnSet_Pos_Settings.Click += new System.EventHandler(this.btnSet_Pos_Settings_Click);
            // 
            // cbModeOfPay
            // 
            this.cbModeOfPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeOfPay.FormattingEnabled = true;
            this.cbModeOfPay.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
            this.cbModeOfPay.Location = new System.Drawing.Point(111, 51);
            this.cbModeOfPay.Name = "cbModeOfPay";
            this.cbModeOfPay.Size = new System.Drawing.Size(189, 24);
            this.cbModeOfPay.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(111, 80);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(189, 22);
            this.txtSalary.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mode of Pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Driver",
            "Conductor",
            "Booker",
            "Inspector"});
            this.cbPosition.Location = new System.Drawing.Point(111, 21);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(189, 24);
            this.cbPosition.TabIndex = 0;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // frmSalarySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(337, 176);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalarySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary Settings";
            this.Load += new System.EventHandler(this.frmSalarySettings_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemovePos;
        private System.Windows.Forms.Button btnSet_Pos_Settings;
        private System.Windows.Forms.ComboBox cbModeOfPay;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}