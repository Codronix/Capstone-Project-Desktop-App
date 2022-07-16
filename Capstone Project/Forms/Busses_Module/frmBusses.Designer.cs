
namespace Capstone_Project
{
    partial class frmBusses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusses));
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnUpdateBus = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExport_Excel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvDataView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column11,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataView.Location = new System.Drawing.Point(12, 36);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.ReadOnly = true;
            this.dgvDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataView.Size = new System.Drawing.Size(776, 402);
            this.dgvDataView.TabIndex = 0;
            // 
            // btnAddBus
            // 
            this.btnAddBus.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBus.BackgroundImage")));
            this.btnAddBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.Location = new System.Drawing.Point(12, 7);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(28, 25);
            this.btnAddBus.TabIndex = 27;
            this.btnAddBus.UseVisualStyleBackColor = false;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateBus.BackgroundImage")));
            this.btnUpdateBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBus.Location = new System.Drawing.Point(45, 7);
            this.btnUpdateBus.Name = "btnUpdateBus";
            this.btnUpdateBus.Size = new System.Drawing.Size(28, 25);
            this.btnUpdateBus.TabIndex = 28;
            this.btnUpdateBus.UseVisualStyleBackColor = false;
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(79, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 25);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(760, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 25);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(623, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(131, 22);
            this.txtSearch.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(468, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Search Bus Number:";
            // 
            // btnExport_Excel
            // 
            this.btnExport_Excel.BackColor = System.Drawing.Color.White;
            this.btnExport_Excel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport_Excel.BackgroundImage")));
            this.btnExport_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport_Excel.ForeColor = System.Drawing.Color.White;
            this.btnExport_Excel.Location = new System.Drawing.Point(113, 7);
            this.btnExport_Excel.Name = "btnExport_Excel";
            this.btnExport_Excel.Size = new System.Drawing.Size(28, 25);
            this.btnExport_Excel.TabIndex = 34;
            this.btnExport_Excel.UseVisualStyleBackColor = false;
            this.btnExport_Excel.Click += new System.EventHandler(this.btnExport_Excel_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bus Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Seat";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Route";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Driver 1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Driver 1 ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Driver 2";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Driver 2 ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Conductor";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Condcutor ID";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Schedule";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // frmBusses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport_Excel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.dgvDataView);
            this.Name = "frmBusses";
            this.Text = "frmBusses";
            this.Load += new System.EventHandler(this.frmBusses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataView;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnUpdateBus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExport_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}