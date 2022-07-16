namespace Capstone_Project
{
    partial class frmAddBusses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDriverNum = new System.Windows.Forms.Label();
            this.cbmDriverNum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvChoices = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbmPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConductorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDriverID_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConductorID = new System.Windows.Forms.TextBox();
            this.txtDriverName_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDriverName_2 = new System.Windows.Forms.TextBox();
            this.txtDriverID_2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearPassengerFareList = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvPassengerFareList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusRoute = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpScheduleFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusSits = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerFareList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(352, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "ADD BUS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 550);
            this.panel1.TabIndex = 31;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDriverNum);
            this.groupBox5.Controls.Add(this.cbmDriverNum);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.dgvChoices);
            this.groupBox5.Controls.Add(this.cbmPosition);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtConductorName);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtDriverID_1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtConductorID);
            this.groupBox5.Controls.Add(this.txtDriverName_1);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtDriverName_2);
            this.groupBox5.Controls.Add(this.txtDriverID_2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 243);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(766, 268);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Assign Driver and Conductor";
            // 
            // lblDriverNum
            // 
            this.lblDriverNum.AutoSize = true;
            this.lblDriverNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverNum.Location = new System.Drawing.Point(194, 24);
            this.lblDriverNum.Name = "lblDriverNum";
            this.lblDriverNum.Size = new System.Drawing.Size(112, 16);
            this.lblDriverNum.TabIndex = 47;
            this.lblDriverNum.Text = "Driver Number:";
            this.lblDriverNum.Visible = false;
            // 
            // cbmDriverNum
            // 
            this.cbmDriverNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmDriverNum.FormattingEnabled = true;
            this.cbmDriverNum.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbmDriverNum.Location = new System.Drawing.Point(312, 19);
            this.cbmDriverNum.Name = "cbmDriverNum";
            this.cbmDriverNum.Size = new System.Drawing.Size(102, 24);
            this.cbmDriverNum.TabIndex = 0;
            this.cbmDriverNum.TabStop = false;
            this.cbmDriverNum.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 45;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChoices.Location = new System.Drawing.Point(6, 49);
            this.dgvChoices.Name = "dgvChoices";
            this.dgvChoices.ReadOnly = true;
            this.dgvChoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoices.Size = new System.Drawing.Size(408, 213);
            this.dgvChoices.TabIndex = 44;
            this.dgvChoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoices_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Name";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // cbmPosition
            // 
            this.cbmPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPosition.FormattingEnabled = true;
            this.cbmPosition.Items.AddRange(new object[] {
            "Driver",
            "Conductor"});
            this.cbmPosition.Location = new System.Drawing.Point(86, 19);
            this.cbmPosition.Name = "cbmPosition";
            this.cbmPosition.Size = new System.Drawing.Size(102, 24);
            this.cbmPosition.TabIndex = 0;
            this.cbmPosition.TabStop = false;
            this.cbmPosition.SelectedIndexChanged += new System.EventHandler(this.cbmPosition_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Driver 1 ID:";
            // 
            // txtConductorName
            // 
            this.txtConductorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductorName.Location = new System.Drawing.Point(552, 193);
            this.txtConductorName.Name = "txtConductorName";
            this.txtConductorName.ReadOnly = true;
            this.txtConductorName.Size = new System.Drawing.Size(208, 22);
            this.txtConductorName.TabIndex = 35;
            this.txtConductorName.TabStop = false;
            this.txtConductorName.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Conductor Name:";
            // 
            // txtDriverID_1
            // 
            this.txtDriverID_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverID_1.Location = new System.Drawing.Point(552, 46);
            this.txtDriverID_1.Name = "txtDriverID_1";
            this.txtDriverID_1.ReadOnly = true;
            this.txtDriverID_1.Size = new System.Drawing.Size(208, 22);
            this.txtDriverID_1.TabIndex = 0;
            this.txtDriverID_1.TabStop = false;
            this.txtDriverID_1.TextChanged += new System.EventHandler(this.txtDriverID_1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Driver 1 Name:";
            // 
            // txtConductorID
            // 
            this.txtConductorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConductorID.Location = new System.Drawing.Point(552, 161);
            this.txtConductorID.Name = "txtConductorID";
            this.txtConductorID.ReadOnly = true;
            this.txtConductorID.Size = new System.Drawing.Size(208, 22);
            this.txtConductorID.TabIndex = 34;
            this.txtConductorID.TabStop = false;
            this.txtConductorID.TextChanged += new System.EventHandler(this.txtConductorID_TextChanged);
            // 
            // txtDriverName_1
            // 
            this.txtDriverName_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName_1.Location = new System.Drawing.Point(552, 77);
            this.txtDriverName_1.Name = "txtDriverName_1";
            this.txtDriverName_1.ReadOnly = true;
            this.txtDriverName_1.Size = new System.Drawing.Size(208, 22);
            this.txtDriverName_1.TabIndex = 0;
            this.txtDriverName_1.TabStop = false;
            this.txtDriverName_1.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Conductor ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Driver 2 ID:";
            // 
            // txtDriverName_2
            // 
            this.txtDriverName_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName_2.Location = new System.Drawing.Point(552, 133);
            this.txtDriverName_2.Name = "txtDriverName_2";
            this.txtDriverName_2.ReadOnly = true;
            this.txtDriverName_2.Size = new System.Drawing.Size(208, 22);
            this.txtDriverName_2.TabIndex = 28;
            this.txtDriverName_2.TabStop = false;
            this.txtDriverName_2.Text = "N/A";
            // 
            // txtDriverID_2
            // 
            this.txtDriverID_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverID_2.Location = new System.Drawing.Point(552, 105);
            this.txtDriverID_2.Name = "txtDriverID_2";
            this.txtDriverID_2.ReadOnly = true;
            this.txtDriverID_2.Size = new System.Drawing.Size(208, 22);
            this.txtDriverID_2.TabIndex = 26;
            this.txtDriverID_2.TabStop = false;
            this.txtDriverID_2.TextChanged += new System.EventHandler(this.txtDriverID_2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Driver 2 Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtBusRoute);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtBusNumber);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtBusSits);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(766, 227);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bus Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnClearPassengerFareList);
            this.groupBox1.Controls.Add(this.btnAddRoute);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtFare);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dgvPassengerFareList);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(279, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 200);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger Fare List:";
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
            // btnClearPassengerFareList
            // 
            this.btnClearPassengerFareList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPassengerFareList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClearPassengerFareList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPassengerFareList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPassengerFareList.ForeColor = System.Drawing.Color.White;
            this.btnClearPassengerFareList.Location = new System.Drawing.Point(384, 121);
            this.btnClearPassengerFareList.Name = "btnClearPassengerFareList";
            this.btnClearPassengerFareList.Size = new System.Drawing.Size(89, 28);
            this.btnClearPassengerFareList.TabIndex = 10;
            this.btnClearPassengerFareList.TabStop = false;
            this.btnClearPassengerFareList.Text = "CLEAR";
            this.btnClearPassengerFareList.UseVisualStyleBackColor = false;
            this.btnClearPassengerFareList.Click += new System.EventHandler(this.btnClearPassengerFareList_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoute.ForeColor = System.Drawing.Color.White;
            this.btnAddRoute.Location = new System.Drawing.Point(384, 53);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(87, 28);
            this.btnAddRoute.TabIndex = 8;
            this.btnAddRoute.TabStop = false;
            this.btnAddRoute.Text = "ADD";
            this.btnAddRoute.UseVisualStyleBackColor = false;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
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
            this.txtFare.TextChanged += new System.EventHandler(this.txtFare_TextChanged);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPassengerFareList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPassengerFareList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengerFareList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerFareList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPassengerFareList.Location = new System.Drawing.Point(7, 52);
            this.dgvPassengerFareList.Name = "dgvPassengerFareList";
            this.dgvPassengerFareList.ReadOnly = true;
            this.dgvPassengerFareList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerFareList.Size = new System.Drawing.Size(371, 142);
            this.dgvPassengerFareList.TabIndex = 48;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Bus Route:";
            // 
            // txtBusRoute
            // 
            this.txtBusRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusRoute.Location = new System.Drawing.Point(108, 80);
            this.txtBusRoute.Name = "txtBusRoute";
            this.txtBusRoute.Size = new System.Drawing.Size(155, 22);
            this.txtBusRoute.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpScheduleFrom);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(9, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 62);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Schedule:";
            // 
            // dtpScheduleFrom
            // 
            this.dtpScheduleFrom.CustomFormat = "h:mm tt";
            this.dtpScheduleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduleFrom.Location = new System.Drawing.Point(110, 21);
            this.dtpScheduleFrom.Name = "dtpScheduleFrom";
            this.dtpScheduleFrom.ShowUpDown = true;
            this.dtpScheduleFrom.Size = new System.Drawing.Size(148, 22);
            this.dtpScheduleFrom.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Start Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bus Number:";
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNumber.Location = new System.Drawing.Point(108, 24);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(155, 22);
            this.txtBusNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bus Seats:";
            // 
            // txtBusSits
            // 
            this.txtBusSits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusSits.Location = new System.Drawing.Point(108, 52);
            this.txtBusSits.Name = "txtBusSits";
            this.txtBusSits.Size = new System.Drawing.Size(155, 22);
            this.txtBusSits.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(682, 517);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "ADD BUS";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddBusses
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
            this.Name = "frmAddBusses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bus";
            this.Load += new System.EventHandler(this.frmAddBusses_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerFareList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConductorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConductorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDriverName_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDriverID_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDriverName_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDriverID_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusSits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpScheduleFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblDriverNum;
        private System.Windows.Forms.ComboBox cbmDriverNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvChoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox cbmPosition;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPassengerFareList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnClearPassengerFareList;
        private System.Windows.Forms.Button btnRemove;
    }
}