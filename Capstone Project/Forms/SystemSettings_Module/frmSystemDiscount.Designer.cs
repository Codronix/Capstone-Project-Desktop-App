
namespace Capstone_Project.Forms.SystemSettings_Module
{
    partial class frmSystemDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSetSeniorDiscount = new System.Windows.Forms.Button();
            this.txtSeniorDiscount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "This setting is applied to the conductor \r\nphone application.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.btnSetSeniorDiscount);
            this.groupBox6.Controls.Add(this.txtSeniorDiscount);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 56);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Senior Citizen Discount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Percent Discount:";
            // 
            // btnSetSeniorDiscount
            // 
            this.btnSetSeniorDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSetSeniorDiscount.FlatAppearance.BorderSize = 0;
            this.btnSetSeniorDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSeniorDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSeniorDiscount.ForeColor = System.Drawing.Color.White;
            this.btnSetSeniorDiscount.Location = new System.Drawing.Point(241, 18);
            this.btnSetSeniorDiscount.Name = "btnSetSeniorDiscount";
            this.btnSetSeniorDiscount.Size = new System.Drawing.Size(76, 24);
            this.btnSetSeniorDiscount.TabIndex = 20;
            this.btnSetSeniorDiscount.Text = "Set";
            this.btnSetSeniorDiscount.UseVisualStyleBackColor = false;
            this.btnSetSeniorDiscount.Click += new System.EventHandler(this.btnSetSeniorDiscount_Click);
            // 
            // txtSeniorDiscount
            // 
            this.txtSeniorDiscount.Location = new System.Drawing.Point(136, 19);
            this.txtSeniorDiscount.Name = "txtSeniorDiscount";
            this.txtSeniorDiscount.Size = new System.Drawing.Size(99, 22);
            this.txtSeniorDiscount.TabIndex = 16;
            this.txtSeniorDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSystemDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(350, 128);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemDiscount";
            this.Text = "System Discount";
            this.Load += new System.EventHandler(this.frmSystemDiscount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSetSeniorDiscount;
        private System.Windows.Forms.TextBox txtSeniorDiscount;
    }
}