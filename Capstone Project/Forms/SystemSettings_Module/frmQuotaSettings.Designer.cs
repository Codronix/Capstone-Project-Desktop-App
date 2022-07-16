
namespace Capstone_Project.Forms.SystemSettings_Module
{
    partial class frmQuotaSettings
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtZeroViolations = new System.Windows.Forms.TextBox();
            this.txtTwoViolations = new System.Windows.Forms.TextBox();
            this.txtOneViolations = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHigh_AdditionalPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLow_AdditionalPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHighQuota = new System.Windows.Forms.TextBox();
            this.txtLowQuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnSetSettings);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 319);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtZeroViolations);
            this.groupBox4.Controls.Add(this.txtTwoViolations);
            this.groupBox4.Controls.Add(this.txtOneViolations);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 130);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traffic Violation Settings";
            // 
            // txtZeroViolations
            // 
            this.txtZeroViolations.Location = new System.Drawing.Point(121, 28);
            this.txtZeroViolations.Name = "txtZeroViolations";
            this.txtZeroViolations.Size = new System.Drawing.Size(177, 22);
            this.txtZeroViolations.TabIndex = 19;
            this.txtZeroViolations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZeroViolations_KeyPress);
            // 
            // txtTwoViolations
            // 
            this.txtTwoViolations.Location = new System.Drawing.Point(121, 93);
            this.txtTwoViolations.Name = "txtTwoViolations";
            this.txtTwoViolations.Size = new System.Drawing.Size(177, 22);
            this.txtTwoViolations.TabIndex = 18;
            this.txtTwoViolations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTwoViolations_KeyPress);
            // 
            // txtOneViolations
            // 
            this.txtOneViolations.Location = new System.Drawing.Point(121, 60);
            this.txtOneViolations.Name = "txtOneViolations";
            this.txtOneViolations.Size = new System.Drawing.Size(177, 22);
            this.txtOneViolations.TabIndex = 14;
            this.txtOneViolations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOneViolations_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Two Violations:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "One Violation:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Zero Violations:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtHigh_AdditionalPay);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtLow_AdditionalPay);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtHighQuota);
            this.groupBox3.Controls.Add(this.txtLowQuota);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 138);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Quota Settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(142, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "=";
            // 
            // txtHigh_AdditionalPay
            // 
            this.txtHigh_AdditionalPay.Location = new System.Drawing.Point(160, 102);
            this.txtHigh_AdditionalPay.Name = "txtHigh_AdditionalPay";
            this.txtHigh_AdditionalPay.Size = new System.Drawing.Size(131, 22);
            this.txtHigh_AdditionalPay.TabIndex = 13;
            this.txtHigh_AdditionalPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHigh_AdditionalPay_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Additional Pay:";
            // 
            // txtLow_AdditionalPay
            // 
            this.txtLow_AdditionalPay.Location = new System.Drawing.Point(160, 58);
            this.txtLow_AdditionalPay.Name = "txtLow_AdditionalPay";
            this.txtLow_AdditionalPay.Size = new System.Drawing.Size(131, 22);
            this.txtLow_AdditionalPay.TabIndex = 11;
            this.txtLow_AdditionalPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLow_AdditionalPay_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Additional Pay:";
            // 
            // txtHighQuota
            // 
            this.txtHighQuota.Location = new System.Drawing.Point(9, 102);
            this.txtHighQuota.Name = "txtHighQuota";
            this.txtHighQuota.Size = new System.Drawing.Size(131, 22);
            this.txtHighQuota.TabIndex = 9;
            this.txtHighQuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHighQuota_KeyPress);
            // 
            // txtLowQuota
            // 
            this.txtLowQuota.Location = new System.Drawing.Point(9, 58);
            this.txtLowQuota.Name = "txtLowQuota";
            this.txtLowQuota.Size = new System.Drawing.Size(131, 22);
            this.txtLowQuota.TabIndex = 9;
            this.txtLowQuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLowQuota_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "High Quota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Low Quota:";
            // 
            // btnSetSettings
            // 
            this.btnSetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSetSettings.FlatAppearance.BorderSize = 0;
            this.btnSetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSettings.ForeColor = System.Drawing.Color.White;
            this.btnSetSettings.Location = new System.Drawing.Point(233, 283);
            this.btnSetSettings.Name = "btnSetSettings";
            this.btnSetSettings.Size = new System.Drawing.Size(76, 24);
            this.btnSetSettings.TabIndex = 8;
            this.btnSetSettings.Text = "Set";
            this.btnSetSettings.UseVisualStyleBackColor = false;
            this.btnSetSettings.Click += new System.EventHandler(this.btnSetSettings_Click);
            // 
            // frmQuotaSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuotaSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quota Settings";
            this.Load += new System.EventHandler(this.frmQuotaAndViolationSettings_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtZeroViolations;
        private System.Windows.Forms.TextBox txtTwoViolations;
        private System.Windows.Forms.TextBox txtOneViolations;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHigh_AdditionalPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLow_AdditionalPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHighQuota;
        private System.Windows.Forms.TextBox txtLowQuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetSettings;
    }
}