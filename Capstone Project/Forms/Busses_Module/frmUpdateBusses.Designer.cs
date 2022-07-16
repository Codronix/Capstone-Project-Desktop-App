namespace Capstone_Project
{
    partial class frmUpdateBusses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBusses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearConductor = new System.Windows.Forms.Button();
            this.txtConductorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConductorID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearDriver2 = new System.Windows.Forms.Button();
            this.btnClearDriver = new System.Windows.Forms.Button();
            this.txtDriverName_2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDriverID_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDriverName_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDriverID_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusRoute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusSits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmPosition = new System.Windows.Forms.ComboBox();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDriverNum = new System.Windows.Forms.Label();
            this.cbmDriverNum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvChoices = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpScheduleFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdateRoute = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvPassengerFareList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerFareList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(666, 517);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 28);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "UDPATE BUS";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearConductor
            // 
            this.btnClearConductor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearConductor.BackColor = System.Drawing.Color.Transparent;
            this.btnClearConductor.Enabled = false;
            this.btnClearConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConductor.ForeColor = System.Drawing.Color.White;
            this.btnClearConductor.Image = ((System.Drawing.Image)(resources.GetObject("btnClearConductor.Image")));
            this.btnClearConductor.Location = new System.Drawing.Point(730, 165);
            this.btnClearConductor.Name = "btnClearConductor";
            this.btnClearConductor.Size = new System.Drawing.Size(30, 18);
            this.btnClearConductor.TabIndex = 38;
            this.btnClearConductor.UseVisualStyleBackColor = false;
            this.btnClearConductor.Click += new System.EventHandler(this.btnClearConductor_Click);
            // 
            // txtConductorName
            // 
            this.txtConductorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductorName.Location = new System.Drawing.Point(553, 192);
            this.txtConductorName.Name = "txtConductorName";
            this.txtConductorName.ReadOnly = true;
            this.txtConductorName.Size = new System.Drawing.Size(171, 22);
            this.txtConductorName.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Conductor Name:";
            // 
            // txtConductorID
            // 
            this.txtConductorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductorID.Location = new System.Drawing.Point(553, 164);
            this.txtConductorID.Name = "txtConductorID";
            this.txtConductorID.ReadOnly = true;
            this.txtConductorID.Size = new System.Drawing.Size(171, 22);
            this.txtConductorID.TabIndex = 34;
            this.txtConductorID.TextChanged += new System.EventHandler(this.txtConductorID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Conductor ID:";
            // 
            // btnClearDriver2
            // 
            this.btnClearDriver2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearDriver2.BackColor = System.Drawing.Color.Transparent;
            this.btnClearDriver2.Enabled = false;
            this.btnClearDriver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDriver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDriver2.ForeColor = System.Drawing.Color.White;
            this.btnClearDriver2.Image = ((System.Drawing.Image)(resources.GetObject("btnClearDriver2.Image")));
            this.btnClearDriver2.Location = new System.Drawing.Point(730, 109);
            this.btnClearDriver2.Name = "btnClearDriver2";
            this.btnClearDriver2.Size = new System.Drawing.Size(30, 18);
            this.btnClearDriver2.TabIndex = 33;
            this.btnClearDriver2.UseVisualStyleBackColor = false;
            this.btnClearDriver2.Click += new System.EventHandler(this.btnClearDriver2_Click);
            // 
            // btnClearDriver
            // 
            this.btnClearDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearDriver.BackColor = System.Drawing.Color.Transparent;
            this.btnClearDriver.Enabled = false;
            this.btnClearDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDriver.ForeColor = System.Drawing.Color.White;
            this.btnClearDriver.Image = ((System.Drawing.Image)(resources.GetObject("btnClearDriver.Image")));
            this.btnClearDriver.Location = new System.Drawing.Point(730, 53);
            this.btnClearDriver.Name = "btnClearDriver";
            this.btnClearDriver.Size = new System.Drawing.Size(30, 18);
            this.btnClearDriver.TabIndex = 32;
            this.btnClearDriver.UseVisualStyleBackColor = false;
            this.btnClearDriver.Click += new System.EventHandler(this.btnClearDriver_Click);
            // 
            // txtDriverName_2
            // 
            this.txtDriverName_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName_2.Location = new System.Drawing.Point(553, 136);
            this.txtDriverName_2.Name = "txtDriverName_2";
            this.txtDriverName_2.ReadOnly = true;
            this.txtDriverName_2.Size = new System.Drawing.Size(171, 22);
            this.txtDriverName_2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Driver 2 Name:";
            // 
            // txtDriverID_2
            // 
            this.txtDriverID_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverID_2.Location = new System.Drawing.Point(553, 108);
            this.txtDriverID_2.Name = "txtDriverID_2";
            this.txtDriverID_2.ReadOnly = true;
            this.txtDriverID_2.Size = new System.Drawing.Size(171, 22);
            this.txtDriverID_2.TabIndex = 26;
            this.txtDriverID_2.TextChanged += new System.EventHandler(this.txtDriverID_2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Driver 2 ID:";
            // 
            // txtDriverName_1
            // 
            this.txtDriverName_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName_1.Location = new System.Drawing.Point(553, 80);
            this.txtDriverName_1.Name = "txtDriverName_1";
            this.txtDriverName_1.ReadOnly = true;
            this.txtDriverName_1.Size = new System.Drawing.Size(171, 22);
            this.txtDriverName_1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Driver 1 Name:";
            // 
            // txtDriverID_1
            // 
            this.txtDriverID_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverID_1.Location = new System.Drawing.Point(553, 52);
            this.txtDriverID_1.Name = "txtDriverID_1";
            this.txtDriverID_1.ReadOnly = true;
            this.txtDriverID_1.Size = new System.Drawing.Size(171, 22);
            this.txtDriverID_1.TabIndex = 23;
            this.txtDriverID_1.TextChanged += new System.EventHandler(this.txtDriverID_1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Driver 1 ID:";
            // 
            // txtBusRoute
            // 
            this.txtBusRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusRoute.Location = new System.Drawing.Point(103, 78);
            this.txtBusRoute.Name = "txtBusRoute";
            this.txtBusRoute.Size = new System.Drawing.Size(161, 22);
            this.txtBusRoute.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bus Route:";
            // 
            // txtBusSits
            // 
            this.txtBusSits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusSits.Location = new System.Drawing.Point(103, 51);
            this.txtBusSits.Name = "txtBusSits";
            this.txtBusSits.Size = new System.Drawing.Size(161, 22);
            this.txtBusSits.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bus Seats:";
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNumber.Location = new System.Drawing.Point(103, 24);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.ReadOnly = true;
            this.txtBusNumber.Size = new System.Drawing.Size(161, 22);
            this.txtBusNumber.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bus Number:";
            // 
            // cbmPosition
            // 
            this.cbmPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmPosition.FormattingEnabled = true;
            this.cbmPosition.Items.AddRange(new object[] {
            "Driver",
            "Conductor"});
            this.cbmPosition.Location = new System.Drawing.Point(81, 25);
            this.cbmPosition.Name = "cbmPosition";
            this.cbmPosition.Size = new System.Drawing.Size(102, 24);
            this.cbmPosition.TabIndex = 0;
            this.cbmPosition.SelectedIndexChanged += new System.EventHandler(this.cbmPosition_SelectedIndexChanged);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Name";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // lblDriverNum
            // 
            this.lblDriverNum.AutoSize = true;
            this.lblDriverNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverNum.Location = new System.Drawing.Point(189, 28);
            this.lblDriverNum.Name = "lblDriverNum";
            this.lblDriverNum.Size = new System.Drawing.Size(112, 16);
            this.lblDriverNum.TabIndex = 42;
            this.lblDriverNum.Text = "Driver Number:";
            this.lblDriverNum.Visible = false;
            // 
            // cbmDriverNum
            // 
            this.cbmDriverNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmDriverNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmDriverNum.FormattingEnabled = true;
            this.cbmDriverNum.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbmDriverNum.Location = new System.Drawing.Point(307, 25);
            this.cbmDriverNum.Name = "cbmDriverNum";
            this.cbmDriverNum.Size = new System.Drawing.Size(102, 24);
            this.cbmDriverNum.TabIndex = 41;
            this.cbmDriverNum.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Position:";
            // 
            // dgvChoices
            // 
            this.dgvChoices.AllowUserToAddRows = false;
            this.dgvChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChoices.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9});
            this.dgvChoices.Location = new System.Drawing.Point(6, 55);
            this.dgvChoices.Name = "dgvChoices";
            this.dgvChoices.ReadOnly = true;
            this.dgvChoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoices.Size = new System.Drawing.Size(408, 214);
            this.dgvChoices.TabIndex = 1;
            this.dgvChoices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvChoices_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDriverNum);
            this.groupBox1.Controls.Add(this.cbmDriverNum);
            this.groupBox1.Controls.Add(this.btnClearConductor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtConductorName);
            this.groupBox1.Controls.Add(this.dgvChoices);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbmPosition);
            this.groupBox1.Controls.Add(this.txtConductorID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDriverID_1);
            this.groupBox1.Controls.Add(this.btnClearDriver2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnClearDriver);
            this.groupBox1.Controls.Add(this.txtDriverName_1);
            this.groupBox1.Controls.Add(this.txtDriverName_2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDriverID_2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 275);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unassigned Driver and Conductor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 550);
            this.panel1.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtBusRoute);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBusSits);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBusNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 227);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bus Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpScheduleFrom);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(6, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 59);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Schedule:";
            // 
            // dtpScheduleFrom
            // 
            this.dtpScheduleFrom.CustomFormat = "h:mm tt";
            this.dtpScheduleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduleFrom.Location = new System.Drawing.Point(103, 21);
            this.dtpScheduleFrom.Name = "dtpScheduleFrom";
            this.dtpScheduleFrom.ShowUpDown = true;
            this.dtpScheduleFrom.Size = new System.Drawing.Size(155, 22);
            this.dtpScheduleFrom.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Start Time:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(319, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "UPDATE BUSSES";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Controls.Add(this.btnUpdateRoute);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtFare);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dgvPassengerFareList);
            this.groupBox4.Controls.Add(this.txtArea);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(279, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 200);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Passenger Fare List:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(384, 87);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 28);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdateRoute
            // 
            this.btnUpdateRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUpdateRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoute.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoute.Location = new System.Drawing.Point(384, 54);
            this.btnUpdateRoute.Name = "btnUpdateRoute";
            this.btnUpdateRoute.Size = new System.Drawing.Size(87, 28);
            this.btnUpdateRoute.TabIndex = 8;
            this.btnUpdateRoute.TabStop = false;
            this.btnUpdateRoute.Text = "UPDATE";
            this.btnUpdateRoute.UseVisualStyleBackColor = false;
            this.btnUpdateRoute.Click += new System.EventHandler(this.btnUpdateRoute_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(166, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Fare:";
            // 
            // txtFare
            // 
            this.txtFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFare.Location = new System.Drawing.Point(216, 21);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(99, 22);
            this.txtFare.TabIndex = 7;
            this.txtFare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFare_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Area:";
            // 
            // dgvPassengerFareList
            // 
            this.dgvPassengerFareList.AllowUserToAddRows = false;
            this.dgvPassengerFareList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPassengerFareList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassengerFareList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPassengerFareList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPassengerFareList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengerFareList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerFareList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPassengerFareList.Location = new System.Drawing.Point(7, 52);
            this.dgvPassengerFareList.Name = "dgvPassengerFareList";
            this.dgvPassengerFareList.ReadOnly = true;
            this.dgvPassengerFareList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerFareList.Size = new System.Drawing.Size(371, 142);
            this.dgvPassengerFareList.TabIndex = 48;
            this.dgvPassengerFareList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPassengerFareList_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Area";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fare";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(61, 21);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(99, 22);
            this.txtArea.TabIndex = 6;
            // 
            // frmUpdateBusses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(798, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateBusses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Busses";
            this.Load += new System.EventHandler(this.frmUpdateBusses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerFareList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClearConductor;
        private System.Windows.Forms.TextBox txtConductorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConductorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearDriver2;
        private System.Windows.Forms.Button btnClearDriver;
        private System.Windows.Forms.TextBox txtDriverName_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDriverID_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDriverName_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDriverID_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusSits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lblDriverNum;
        private System.Windows.Forms.ComboBox cbmDriverNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvChoices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpScheduleFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdateRoute;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPassengerFareList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtArea;
    }
}