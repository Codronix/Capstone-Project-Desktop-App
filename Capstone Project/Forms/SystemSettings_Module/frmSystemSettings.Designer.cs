
namespace Capstone_Project.Forms
{
    partial class frmSystemSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMenuLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemove_Admin = new System.Windows.Forms.Button();
            this.btnUpdate_Admin = new System.Windows.Forms.Button();
            this.btnAdd_Admin = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbnSnRDiscount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuLabel
            // 
            this.lblMenuLabel.AutoSize = true;
            this.lblMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuLabel.ForeColor = System.Drawing.Color.White;
            this.lblMenuLabel.Location = new System.Drawing.Point(225, 9);
            this.lblMenuLabel.Name = "lblMenuLabel";
            this.lblMenuLabel.Size = new System.Drawing.Size(224, 29);
            this.lblMenuLabel.TabIndex = 1;
            this.lblMenuLabel.Text = "SYSTEM ADMINS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbnSnRDiscount);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 303);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemove_Admin);
            this.groupBox5.Controls.Add(this.btnUpdate_Admin);
            this.groupBox5.Controls.Add(this.btnAdd_Admin);
            this.groupBox5.Controls.Add(this.dgvData);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(618, 248);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Admins";
            // 
            // btnRemove_Admin
            // 
            this.btnRemove_Admin.BackColor = System.Drawing.Color.Red;
            this.btnRemove_Admin.FlatAppearance.BorderSize = 0;
            this.btnRemove_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove_Admin.ForeColor = System.Drawing.Color.White;
            this.btnRemove_Admin.Location = new System.Drawing.Point(520, 212);
            this.btnRemove_Admin.Name = "btnRemove_Admin";
            this.btnRemove_Admin.Size = new System.Drawing.Size(92, 30);
            this.btnRemove_Admin.TabIndex = 7;
            this.btnRemove_Admin.Text = "Remove";
            this.btnRemove_Admin.UseVisualStyleBackColor = false;
            this.btnRemove_Admin.Click += new System.EventHandler(this.btnRemove_Admin_Click);
            // 
            // btnUpdate_Admin
            // 
            this.btnUpdate_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUpdate_Admin.FlatAppearance.BorderSize = 0;
            this.btnUpdate_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Admin.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Admin.Location = new System.Drawing.Point(422, 212);
            this.btnUpdate_Admin.Name = "btnUpdate_Admin";
            this.btnUpdate_Admin.Size = new System.Drawing.Size(92, 30);
            this.btnUpdate_Admin.TabIndex = 6;
            this.btnUpdate_Admin.Text = "Update";
            this.btnUpdate_Admin.UseVisualStyleBackColor = false;
            this.btnUpdate_Admin.Click += new System.EventHandler(this.btnUpdate_Admin_Click);
            // 
            // btnAdd_Admin
            // 
            this.btnAdd_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAdd_Admin.FlatAppearance.BorderSize = 0;
            this.btnAdd_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Admin.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Admin.Location = new System.Drawing.Point(324, 212);
            this.btnAdd_Admin.Name = "btnAdd_Admin";
            this.btnAdd_Admin.Size = new System.Drawing.Size(92, 30);
            this.btnAdd_Admin.TabIndex = 5;
            this.btnAdd_Admin.Text = "Add Admin";
            this.btnAdd_Admin.UseVisualStyleBackColor = false;
            this.btnAdd_Admin.Click += new System.EventHandler(this.btnAdd_Admin_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Location = new System.Drawing.Point(6, 21);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(606, 185);
            this.dgvData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID/Username";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tbnSnRDiscount
            // 
            this.tbnSnRDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbnSnRDiscount.FlatAppearance.BorderSize = 0;
            this.tbnSnRDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnSnRDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSnRDiscount.ForeColor = System.Drawing.Color.White;
            this.tbnSnRDiscount.Location = new System.Drawing.Point(14, 267);
            this.tbnSnRDiscount.Name = "tbnSnRDiscount";
            this.tbnSnRDiscount.Size = new System.Drawing.Size(92, 30);
            this.tbnSnRDiscount.TabIndex = 8;
            this.tbnSnRDiscount.Text = "Discounts";
            this.tbnSnRDiscount.UseVisualStyleBackColor = false;
            this.tbnSnRDiscount.Click += new System.EventHandler(this.tbnSnRDiscount_Click);
            // 
            // frmSystemSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(670, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMenuLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.frmSystemSettings_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemove_Admin;
        private System.Windows.Forms.Button btnUpdate_Admin;
        private System.Windows.Forms.Button btnAdd_Admin;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button tbnSnRDiscount;
    }
}