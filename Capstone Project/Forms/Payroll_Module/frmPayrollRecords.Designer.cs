namespace Capstone_Project
{
    partial class frmPayrollRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayrollRecords));
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.btnExport_Excel = new System.Windows.Forms.Button();
            this.btnDeductions = new System.Windows.Forms.Button();
            this.btnIncentives = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataView
            // 
            this.dgvDataView.AllowUserToAddRows = false;
            this.dgvDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataView.Location = new System.Drawing.Point(12, 45);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.ReadOnly = true;
            this.dgvDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataView.Size = new System.Drawing.Size(776, 393);
            this.dgvDataView.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Position";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gross";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Deduction";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Net Pay";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnPayroll
            // 
            this.btnPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Location = new System.Drawing.Point(564, 12);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(109, 27);
            this.btnPayroll.TabIndex = 52;
            this.btnPayroll.Text = "PAYROLL";
            this.btnPayroll.UseVisualStyleBackColor = false;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // btnPayslip
            // 
            this.btnPayslip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayslip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPayslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayslip.ForeColor = System.Drawing.Color.White;
            this.btnPayslip.Location = new System.Drawing.Point(679, 12);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(109, 27);
            this.btnPayslip.TabIndex = 53;
            this.btnPayslip.Text = "PAYSLIP";
            this.btnPayslip.UseVisualStyleBackColor = false;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // btnExport_Excel
            // 
            this.btnExport_Excel.BackColor = System.Drawing.Color.White;
            this.btnExport_Excel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport_Excel.BackgroundImage")));
            this.btnExport_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport_Excel.ForeColor = System.Drawing.Color.White;
            this.btnExport_Excel.Location = new System.Drawing.Point(12, 12);
            this.btnExport_Excel.Name = "btnExport_Excel";
            this.btnExport_Excel.Size = new System.Drawing.Size(28, 25);
            this.btnExport_Excel.TabIndex = 54;
            this.btnExport_Excel.UseVisualStyleBackColor = false;
            this.btnExport_Excel.Click += new System.EventHandler(this.btnExport_Excel_Click);
            // 
            // btnDeductions
            // 
            this.btnDeductions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeductions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDeductions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductions.ForeColor = System.Drawing.Color.White;
            this.btnDeductions.Location = new System.Drawing.Point(449, 12);
            this.btnDeductions.Name = "btnDeductions";
            this.btnDeductions.Size = new System.Drawing.Size(109, 27);
            this.btnDeductions.TabIndex = 55;
            this.btnDeductions.Text = "DEDUCTIONS";
            this.btnDeductions.UseVisualStyleBackColor = false;
            this.btnDeductions.Click += new System.EventHandler(this.btnDeductions_Click);
            // 
            // btnIncentives
            // 
            this.btnIncentives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncentives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnIncentives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncentives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncentives.ForeColor = System.Drawing.Color.White;
            this.btnIncentives.Location = new System.Drawing.Point(334, 12);
            this.btnIncentives.Name = "btnIncentives";
            this.btnIncentives.Size = new System.Drawing.Size(109, 27);
            this.btnIncentives.TabIndex = 56;
            this.btnIncentives.Text = "INCENTIVES";
            this.btnIncentives.UseVisualStyleBackColor = false;
            this.btnIncentives.Click += new System.EventHandler(this.btnIncentives_Click);
            // 
            // frmPayrollRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncentives);
            this.Controls.Add(this.btnDeductions);
            this.Controls.Add(this.btnExport_Excel);
            this.Controls.Add(this.btnPayslip);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.dgvDataView);
            this.Name = "frmPayrollRecords";
            this.Text = "frmPayrollRecords";
            this.Load += new System.EventHandler(this.frmPayrollRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataView;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnPayslip;
        private System.Windows.Forms.Button btnExport_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnDeductions;
        private System.Windows.Forms.Button btnIncentives;
    }
}