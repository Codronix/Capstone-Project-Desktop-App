using Capstone_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    public partial class frmPayroll : Form
    {
        //Declaration of Variables
        Database Cloud_Database = new Database();
        frmPayrollRecords frm_payroll_records;

        double salary = 0;
        double Quota_1 = 0;
        double Quota_2 = 0;
        double Violation_None = 0;
        double Violation_1 = 0;
        double Violation_2 = 0;
        double Hours_Work = 0;
        double HourlyWage = 0;
        double WeeklyWage = 0;
        double DailyWage = 0;
        double NetPay = 0;
        double gross_pay = 0;
        double total_deductions = 0;
        double Other_Deductions = 0;
        string quota_addpay;
        string traffic_violation_addpay;
        string date;
        List<string> Deductions = new List<string>();
        public frmPayroll(frmPayrollRecords frm)
        {
            InitializeComponent();
            frm_payroll_records = frm;
        }
        private async Task Populate_cbmBusses() 
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Bus_Data/Busses/"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Bus_Data> bus_data = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Bus_Data>>());
                foreach (var get in bus_data)
                {
                    cbmBusNumber.Items.Add(get.Value.bus_number);
                }
            }
        }
        private async Task LoadDeductions(DataGridView dataGrid, string Employee_ID)
        {
            Deductions.Clear();
            dataGrid.Rows.Clear();
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Deductions_Data"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Deductions_Data> getData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Deductions_Data>>());
                foreach (var get in getData )
                {
                    dataGrid.Rows.Add(
                        get.Value.DeductionType,
                        get.Value.MonthlyDeduction
                        );
                    Deductions.Add(get.Value.DeductionType); // GET THE DEDUCTION TYPE
                }
            }
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{Employee_ID}/Other_Deductions/"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Deductions_Data> getData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Deductions_Data>>());
                foreach (var get in getData)
                {
                    dataGrid.Rows.Add(
                        get.Value.DeductionType,
                        get.Value.MonthlyDeduction
                        );
                    Deductions.Add(get.Value.DeductionType);
                }
            }
        }
        private async Task LOAD_Quota_Details()
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Quota_Settings"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Quota_Data GET_Quota_Details = Cloud_Database.response.ResultAs<Quota_Data>();
                rdbLowQuota.Text = GET_Quota_Details.Low_Quota;
                txtLow_AdditionalPay.Text = GET_Quota_Details.Low_Quota_AddPay;
                rdbHighQuota.Text = GET_Quota_Details.High_Quota;
                txtHigh_AdditionalPay.Text = GET_Quota_Details.High_Quota_AddPay;
            }
        }
        private async Task LOAD_Violation_Details()
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Violation_Settings"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                TrafficViolation_Data GET_trafficViolation_Data = Cloud_Database.response.ResultAs<TrafficViolation_Data>();
                txtZeroViolations.Text = GET_trafficViolation_Data.Violation_None;
                txtOneViolations.Text = GET_trafficViolation_Data.Violation_One;
                txtTwoViolations.Text = GET_trafficViolation_Data.Violation_Two;
            }
        }
        private async Task LoadBussesData() 
        {
            try
            {
                dgvViewBusEmployee.Rows.Clear();
                string bus_number = cbmBusNumber.Text;
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"BusTripHistory/{bus_number}/{dtpBusPersonel_DateFrom.Value.ToString("MMddyyyy")}"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    BusTripHistory busTripHistory = Cloud_Database.response.ResultAs<BusTripHistory>();
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{busTripHistory.BusDriverID_1}"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        Employee_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Employee_Data>());
                        dgvViewBusEmployee.Rows.Add(
                            emp_data.id,
                            emp_data.position,
                            $"{emp_data.surname}, {emp_data.firstname}",
                            $"{emp_data.salary} - {emp_data.mode_of_pay}"
                            );
                    }
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{busTripHistory.BusDriverID_2}"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        Employee_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Employee_Data>());
                        dgvViewBusEmployee.Rows.Add(
                            emp_data.id,
                            emp_data.position,
                            $"{emp_data.surname}, {emp_data.firstname}",
                            $"{emp_data.salary} - {emp_data.mode_of_pay}"
                            );
                    }
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{busTripHistory.BusConductorID}"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        Employee_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Employee_Data>());
                        dgvViewBusEmployee.Rows.Add(
                            emp_data.id,
                            emp_data.position,
                            $"{emp_data.surname}, {emp_data.firstname}",
                            $"{emp_data.salary} - {emp_data.mode_of_pay}"
                            );
                    }
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"BusTripRecords_Data/{dtpBusPersonel_DateFrom.Value.ToString("MMddyyyy")}/{bus_number}"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        BusTripRecords_Data HourTravel = Cloud_Database.response.ResultAs<BusTripRecords_Data>();
                        txtBusPersonel_HoursWork.Text = HourTravel.TotalHoursTravel;
                    }
                }
            }
            catch 
            {
                
            }
        }
        private async Task LoadBookerData() 
        {
            try
            {
                dgvViewBookerEmployee.Rows.Clear();
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Account_Data/Booker/"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Dictionary<string, Accounts_Data> emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Accounts_Data>>());
                    foreach (var get in emp_data)
                    {
                        dgvViewBookerEmployee.Rows.Add(
                            get.Value.id,
                            get.Value.surname + ", " + get.Value.firstname,
                            get.Value.assigned_to,
                            get.Value.position
                            );
                    }
                }
            }
            catch 
            {
                
            }
        }
        private async Task LoadInspectorData()
        {
            try
            {
                dgvViewInspectorEmployee.Rows.Clear();
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Account_Data/Inspector/"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Dictionary<string, Accounts_Data> emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Accounts_Data>>());
                    foreach (var get in emp_data)
                    {
                        dgvViewInspectorEmployee.Rows.Add(
                            get.Value.id,
                            get.Value.surname + ", " + get.Value.firstname,
                            get.Value.assigned_to,
                            get.Value.position
                            );
                    }
                }
            }
            catch
            {

            }
        }
        private async void DisplaySelected_Inspector()
        {
            try
            {
                if (dgvViewInspectorEmployee.SelectedCells.Count > 0)
                {
                    int SelectedRowIndex = dgvViewInspectorEmployee.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvViewInspectorEmployee.Rows[SelectedRowIndex];

                    txtInspector_ID.Text = row.Cells[0].Value.ToString();
                    txtInspector_Name.Text = row.Cells[1].Value.ToString();
                    txtInspector_Position.Text = row.Cells[3].Value.ToString();
                    txtInspector_ModeOfPay.Text = row.Cells[2].Value.ToString();
                    await LoadDeductions(dataGridView3, row.Cells[0].Value.ToString());
                }
                await ComputePayroll_Inspector();
            }
            catch
            {

            }
        }
        private async void DisplaySelected_BusPersonel() 
        {
            try
            {
                if (dgvViewBusEmployee.SelectedCells.Count > 0)
                {
                    int SelectedRowIndex = dgvViewBusEmployee.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvViewBusEmployee.Rows[SelectedRowIndex];

                    txtBusPersonel_ID.Text = row.Cells[0].Value.ToString();
                    txtBusPersonel_Position.Text = row.Cells[1].Value.ToString();
                    txtBusPersonel_Name.Text = row.Cells[2].Value.ToString();
                    txtBusPersonel_ModeOfPay.Text = row.Cells[3].Value.ToString();
                    await LoadDeductions(dataGridView1,row.Cells[0].Value.ToString());
                }
                await ComputePayroll_BusPersonel();
            }
            catch
            {

            }
        }
        private async Task DisplaySelected_Booker() 
        {
            try
            {
                if (dgvViewBookerEmployee.SelectedCells.Count > 0)
                {

                    int SelectedRowIndex = dgvViewBookerEmployee.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvViewBookerEmployee.Rows[SelectedRowIndex];

                    Cloud_Database.response = await Task.Run (() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{row.Cells[0].Value}"));
                    Employee_Data emp_data = Cloud_Database.response.ResultAs<Employee_Data>();

                    txtBooker_ID.Text = row.Cells[0].Value.ToString();
                    txtBooker_Name.Text = row.Cells[1].Value.ToString();
                    txtBooker_Position.Text = row.Cells[3].Value.ToString();
                    await LoadDeductions(dataGridView2, row.Cells[0].Value.ToString());
                }
                await ComputePayroll_Booker();
            }
            catch
            {
                
            }
        }
        private async Task ComputePayroll_BusPersonel() 
        {
            try
            {
                Cloud_Database.response = await Task.Run (() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{txtBusPersonel_ID.Text}"));
                Employee_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Employee_Data>());

                salary = Double.Parse(emp_data.salary);
                Quota_1 = Double.Parse(txtLow_AdditionalPay.Text);
                Quota_2 = Double.Parse(txtHigh_AdditionalPay.Text);
                Violation_None = Double.Parse(txtZeroViolations.Text);
                Violation_1 = Double.Parse(txtOneViolations.Text);
                Violation_2 = Double.Parse(txtTwoViolations.Text);
                Hours_Work = Double.Parse(txtBusPersonel_HoursWork.Text);
                HourlyWage = Math.Round(salary / 8, 2);

                if (!(string.IsNullOrWhiteSpace(txtBusPersonel_ID.Text)) || !(string.IsNullOrEmpty(txtBusPersonel_ID.Text)))
                {
                    txtBusPersonel_HourlyWage.Text = HourlyWage.ToString();
                    NetPay = HourlyWage * Hours_Work;
                    if (rdbLowQuota.Checked)
                    {
                        NetPay += Quota_1;
                        quota_addpay = Quota_1.ToString("0,0.00");
                    }
                    else if (rdbHighQuota.Checked)
                    {
                        NetPay += Quota_2;
                        quota_addpay = Quota_2.ToString("0,0.00");
                    }
                    if (rdbViolation_None.Checked)
                    {
                        NetPay += Violation_None;
                        traffic_violation_addpay = Violation_None.ToString("0,0.00");
                    }
                    else if (rdbViolation_1.Checked)
                    {
                        NetPay += Violation_1;
                        traffic_violation_addpay = Violation_1.ToString("0,0.00");
                    }
                    else if (rdbViolation_2.Checked)
                    {
                        NetPay += Violation_2;
                        traffic_violation_addpay = Violation_2.ToString("0,0.00");
                    }
                    txtBusPersonel_NetPay.Text = NetPay.ToString("0,0.00");
                    for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                    {
                        if ((bool)dataGridView1.Rows[rows].Cells[2].Value == true)
                        {
                            NetPay -= double.Parse(dataGridView1.Rows[rows].Cells[1].Value.ToString());
                            txtBusPersonel_NetPay.Text = NetPay.ToString("0,0.00");
                        }
                    }
                }
            }
            catch{}
        }
        private async Task ComputePayroll_Inspector()
        {
            try
            {
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{txtInspector_ID.Text}"));
                Employee_Data emp_data = Cloud_Database.response.ResultAs<Employee_Data>();

                salary = Double.Parse(emp_data.salary);
                HourlyWage = Math.Round(salary / 24 / 8, 2);
                DailyWage = Math.Round(8 * HourlyWage, 2);
                Hours_Work = Double.Parse(txtInspector_HoursWork.Text);
                txtInspector_ModeOfPay.Text = $"{emp_data.salary} - {emp_data.mode_of_pay} | {DailyWage} - Daily";
                if (!(string.IsNullOrWhiteSpace(txtInspector_ID.Text)) || !(string.IsNullOrEmpty(txtInspector_ID.Text)))
                {
                    txtInspector_HourlyWage.Text = HourlyWage.ToString();
                    NetPay = Math.Round(HourlyWage * Hours_Work, 2);
                    txtInspector_NetPay.Text = NetPay.ToString("0,0.00");
                    for (int rows = 0; rows < dataGridView3.Rows.Count; rows++)
                    {
                        if (dataGridView3.Rows[rows].Cells[2].Value != null)
                        {
                            if ((bool)dataGridView3.Rows[rows].Cells[2].Value == true)
                            {
                                NetPay -= double.Parse(dataGridView3.Rows[rows].Cells[1].Value.ToString());
                                txtInspector_NetPay.Text = NetPay.ToString("0,0.00");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private async Task ComputePayroll_Booker()
        {
            try
            {
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees/{txtBooker_ID.Text}"));
                Employee_Data emp_data = Cloud_Database.response.ResultAs<Employee_Data>();

                salary = Double.Parse(emp_data.salary);
                HourlyWage = Math.Round(salary / 22 / 8, 2);
                DailyWage = Math.Round(8 * HourlyWage, 2);
                Hours_Work = Double.Parse(txtBooker_HoursWork.Text);
                txtBooker_ModeOfPay.Text = $"{emp_data.salary} - {emp_data.mode_of_pay} | {DailyWage} - Daily";
                if (!(string.IsNullOrWhiteSpace(txtBooker_ID.Text)) || !(string.IsNullOrEmpty(txtBooker_ID.Text)))
                {
                    txtBooker_HourlyWage.Text = HourlyWage.ToString();
                    NetPay = Math.Round(HourlyWage * Hours_Work, 2);
                    txtBooker_NetPay.Text = NetPay.ToString("0,0.00");
                    for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
                    {
                        if (dataGridView2.Rows[rows].Cells[2].Value != null)
                        {
                            if ((bool)dataGridView2.Rows[rows].Cells[2].Value == true)
                            {
                                NetPay -= double.Parse(dataGridView2.Rows[rows].Cells[1].Value.ToString());
                                txtBooker_NetPay.Text = NetPay.ToString("0,0.00");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private async Task AddPayroll_BusPersonel()
        {

            HourlyWage = Double.Parse(txtBusPersonel_HourlyWage.Text);
            Hours_Work = Double.Parse(txtBusPersonel_HoursWork.Text);
            Quota_1 = Double.Parse(txtLow_AdditionalPay.Text);
            Quota_2 = Double.Parse(txtHigh_AdditionalPay.Text);
            Violation_None = Double.Parse(txtZeroViolations.Text);
            Violation_1 = Double.Parse(txtOneViolations.Text);
            Violation_2 = Double.Parse(txtTwoViolations.Text);
            if (!(string.IsNullOrWhiteSpace(txtBusPersonel_ID.Text)) || !(string.IsNullOrEmpty(txtBusPersonel_ID.Text)))
            {
                gross_pay = Math.Round(HourlyWage * Hours_Work, 2);
                if (rdbLowQuota.Checked)
                {
                    gross_pay += Math.Round(Quota_1, 2);
                }
                else if (rdbHighQuota.Checked)
                {
                    gross_pay += Math.Round(Quota_2, 2);
                }
                if (rdbViolation_None.Checked)
                {
                    gross_pay += Math.Round(Violation_None, 2);
                }
                else if (rdbViolation_1.Checked)
                {
                    gross_pay += Math.Round(Violation_1, 2);
                }
                else if (rdbViolation_2.Checked)
                {
                    gross_pay += Math.Round(Violation_2, 2);
                }

                NetPay = gross_pay;
                total_deductions = gross_pay - double.Parse(txtBusPersonel_NetPay.Text);
                Payroll_Data payroll_data = new Payroll_Data()
                {
                    date = dtpBusPersonel_DateFrom.Text,
                    employee_id = txtBusPersonel_ID.Text,
                    employee_name = txtBusPersonel_Name.Text,
                    position = txtBusPersonel_Position.Text,
                    hourly_rate = txtBusPersonel_HourlyWage.Text,
                    total_hours_work = Hours_Work.ToString(),
                    gross_pay = gross_pay.ToString("0,0.00"),
                    Traffic_Violation_AddPay = traffic_violation_addpay,
                    quota_AddPay = quota_addpay,
                    total_deduction = total_deductions.ToString("0,0"),
                    net_pay = txtBusPersonel_NetPay.Text
                };
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{txtBusPersonel_ID.Text}", payroll_data));
                AddDeductions(txtBusPersonel_ID.Text,dataGridView1);
                await frm_payroll_records.LoadData();
                Other_Deductions = 0;
                MessageBox.Show("Payroll Record has been added.", "Payroll Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async Task AddPayroll_Booker()
        {
            HourlyWage = Double.Parse(txtBooker_HourlyWage.Text);
            Hours_Work = Double.Parse(txtBooker_HoursWork.Text);
            gross_pay = Math.Round(HourlyWage * Hours_Work, 2);
            if (!(string.IsNullOrWhiteSpace(txtBooker_ID.Text)) || !(string.IsNullOrEmpty(txtBooker_ID.Text)))
            {
                NetPay = gross_pay;
                total_deductions = gross_pay - double.Parse(txtBooker_NetPay.Text);
                Payroll_Data payroll_data = new Payroll_Data()
                {
                    date = dtpBooker_DateFrom.Text,
                    employee_id = txtBooker_ID.Text,
                    employee_name = txtBooker_Name.Text,
                    position = txtBooker_Position.Text,
                    hourly_rate = txtBooker_HourlyWage.Text,
                    total_hours_work = Hours_Work.ToString(),
                    gross_pay = gross_pay.ToString("0,0.00"),
                    total_deduction = total_deductions.ToString("0,0.00"),
                    net_pay = txtBooker_NetPay.Text
                };
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{txtBooker_ID.Text}", payroll_data));
                AddDeductions(txtBooker_ID.Text,dataGridView2);
                await frm_payroll_records.LoadData();
                MessageBox.Show("Payroll Record has been added.", "Payroll Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                total_deductions = 0;
            }
        }
        private async Task AddPayroll_Inspector()
        {
            HourlyWage = Double.Parse(txtInspector_HourlyWage.Text);
            Hours_Work = Double.Parse(txtInspector_HoursWork.Text);
            gross_pay = Math.Round(HourlyWage * Hours_Work, 2);
            if (!(string.IsNullOrWhiteSpace(txtInspector_ID.Text)) || !(string.IsNullOrEmpty(txtInspector_ID.Text)))
            {
                NetPay = gross_pay;
                total_deductions = gross_pay - double.Parse(txtInspector_NetPay.Text);
                Payroll_Data payroll_data = new Payroll_Data()
                {
                    date = dtpInspector_DateFrom.Text,
                    employee_id = txtInspector_ID.Text,
                    employee_name = txtInspector_Name.Text,
                    position = txtInspector_Position.Text,
                    hourly_rate = txtInspector_HourlyWage.Text,
                    total_hours_work = Hours_Work.ToString(),
                    gross_pay = gross_pay.ToString("0,0.00"),
                    total_deduction = total_deductions.ToString("0,0.00"),
                    net_pay = txtInspector_NetPay.Text
                };
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{txtInspector_ID.Text}", payroll_data));
                AddDeductions(txtInspector_ID.Text, dataGridView3);
                await frm_payroll_records.LoadData();
                MessageBox.Show("Payroll Record has been added.", "Payroll Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                total_deductions = 0;
            }
        }
        private async void AddDeductions(string EmpID, DataGridView dataGridView)
        {
            for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
            {
                if (dataGridView.Rows[rows].Cells[2].Value != null)
                {
                    if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals(Deductions[0]) && (bool)dataGridView.Rows[rows].Cells[2].Value == true)
                    {
                        Deductions_Data deductions_Data = new Deductions_Data
                        {
                            DeductionType = dataGridView.Rows[rows].Cells[0].Value.ToString(),
                            MonthlyDeduction = dataGridView.Rows[rows].Cells[1].Value.ToString()
                        };
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{EmpID}/Deductions/{dataGridView.Rows[rows].Cells[0].Value.ToString()}", deductions_Data));
                    }
                    else if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals(Deductions[1]) && (bool)dataGridView.Rows[rows].Cells[2].Value == true)
                    {
                        Deductions_Data deductions_Data = new Deductions_Data
                        {
                            DeductionType = dataGridView.Rows[rows].Cells[0].Value.ToString(),
                            MonthlyDeduction = dataGridView.Rows[rows].Cells[1].Value.ToString()
                        };
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{EmpID}/Deductions/{dataGridView.Rows[rows].Cells[0].Value.ToString()}", deductions_Data));
                    }
                    else if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals(Deductions[2]) && (bool)dataGridView.Rows[rows].Cells[2].Value == true)
                    {
                        Deductions_Data deductions_Data = new Deductions_Data
                        {
                            DeductionType = dataGridView.Rows[rows].Cells[0].Value.ToString(),
                            MonthlyDeduction = dataGridView.Rows[rows].Cells[1].Value.ToString()
                        };
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{EmpID}/Deductions/{dataGridView.Rows[rows].Cells[0].Value.ToString()}", deductions_Data));
                    }
                    else if (!dataGridView.Rows[rows].Cells[0].Value.ToString().Equals(Deductions[0]) && (bool)dataGridView.Rows[rows].Cells[2].Value == true
                        || !dataGridView.Rows[rows].Cells[0].Value.ToString().Equals(Deductions[1]) && (bool)dataGridView.Rows[rows].Cells[2].Value == true
                        || !dataGridView.Rows[rows].Cells[0].Value.ToString().Equals(Deductions[2]) && (bool)dataGridView.Rows[rows].Cells[2].Value == true)
                    {
                        Other_Deductions = Other_Deductions + double.Parse(dataGridView.Rows[rows].Cells[1].Value.ToString());
                        Deductions_Data deductions_Data = new Deductions_Data
                        {
                            DeductionType = "Other Duductions",
                            MonthlyDeduction = Other_Deductions.ToString()
                        };
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Payroll_Records/{txtBusPersonel_ID.Text}/Deductions/Other_Deductions", deductions_Data));
                    }
                }
            }
        }
        private async void frmPayroll_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            rdbQuota_None.Checked = true;
            rdbViolation_None.Checked = false;
            try
            {
                await Populate_cbmBusses();
                await LoadBookerData();
                await LoadInspectorData();
                await LOAD_Quota_Details();
                await LOAD_Violation_Details();
            }
            catch 
            {
                
            }
        }
        private void dgvViewBusEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplaySelected_BusPersonel();
        }
        private async void cbmBusNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadBussesData();
        }
        private async void txtBusPersonel_HoursWork_TextChanged(object sender, EventArgs e)
        {
            if (txtBusPersonel_HoursWork.Text.Equals("")) 
            {
                txtBusPersonel_HoursWork.Text = "1";
            }
            else
            {
                await ComputePayroll_BusPersonel();
            }
        }
        private async void txtQuota_1_TextChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void txtQuota_2_TextChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void txtViolation_none_TextChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void txtViolation_1_TextChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void txtViolation_2_TextChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void rdbQuota_None_CheckedChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void rdbQuota_1_CheckedChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void rdbQuota_2_CheckedChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void rdbViolation_None_CheckedChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void rdbViolation_1_CheckedChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }

        private async void rdbViolation_2_CheckedChanged(object sender, EventArgs e)
        {
            await ComputePayroll_BusPersonel();
        }
        private async void dgvViewBookerEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await DisplaySelected_Booker();
        }

        private async void txtBooker_HoursWork_TextChanged(object sender, EventArgs e)
        {
            if (txtBooker_HoursWork.Text.Equals(""))
            {
                txtBooker_HoursWork.Text = "1";
            }
            else
            {
                await ComputePayroll_Booker();
            }
        }
        private async void btnBusPersonel_Pay_Click(object sender, EventArgs e)
        {
            await AddPayroll_BusPersonel();
        }

        private async void btnBooker_Pay_Click(object sender, EventArgs e)
        {
            await AddPayroll_Booker();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cbColApply.Index && e.RowIndex != -1)
            {
                //await ComputePayroll_BusPersonel();
            }
        }

        private async void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == cbColApply.Index && e.RowIndex != -1)
            {
                dataGridView1.EndEdit();
                await ComputePayroll_BusPersonel();
            }
        }

        private async void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == cbColApply2.Index && e.RowIndex != -1)
            {
                dataGridView2.EndEdit();
                await ComputePayroll_Booker();
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cbColApply2.Index && e.RowIndex != -1)
            {
                //await ComputePayroll_BusPersonel();
            }
        }

        private void dgvViewInspectorEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplaySelected_Inspector();
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cbColApply3.Index && e.RowIndex != -1)
            {
                //await ComputePayroll_BusPersonel();
            }
        }

        private async void dataGridView3_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == cbColApply3.Index && e.RowIndex != -1)
            {
                dataGridView3.EndEdit();
                await ComputePayroll_Inspector();
            }
        }

        private void txtInspector_HoursWork_TextChanged(object sender, EventArgs e)
        {
            ComputePayroll_Inspector();
        }

        private void txtBusPersonel_HoursWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtBooker_HoursWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtInspector_HoursWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private async void dtpBusPersonel_DateFrom_ValueChanged(object sender, EventArgs e)
        {
            await LoadBussesData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPayroll_Inspector();
        }
    }
}