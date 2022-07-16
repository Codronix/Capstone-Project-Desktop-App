using Capstone_Project.Data;
using Capstone_Project.Forms.SystemSettings_Module;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    public partial class frmEmployee : Form
    {

        Database Cloud_Database = new Database();

        public frmEmployee()
        {
            InitializeComponent();
        }
   
        public static int GetAge(DateTime birthDate)
        {
            DateTime n = DateTime.Now;
            int age = n.Year - birthDate.Year;

            if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }

        public async Task LoadData() 
        {
            try
            {
                dgvDataView.Rows.Clear();
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Employee_Data/Employees"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Dictionary<string, Employee_Data> getData = Cloud_Database.response.ResultAs<Dictionary<string, Employee_Data>>();

                    foreach (var get in getData)
                    {
                        dgvDataView.Rows.Add(
                            get.Value.id,
                            get.Value.surname + ", " + get.Value.firstname + " " + get.Value.mi,
                            get.Value.birthday,
                            GetAge(DateTime.ParseExact(get.Value.birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture)),
                            get.Value.contact_num,
                            get.Value.address,
                            get.Value.position,
                            get.Value.mode_of_pay,
                            get.Value.salary,
                            get.Value.date_hired
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public async Task UpdateBusData()
        {
            try
            {
                if (dgvDataView.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgvDataView.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvDataView.Rows[selectedrowindex];

                    string employee_id = row.Cells[0].Value.ToString();
                    string position = row.Cells[6].Value.ToString();

                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{position}/{employee_id}"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        //get the bus number assgined to employee
                        Accounts_Data result = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());
                        string bus_number = result.assigned_to;

                        if (!(string.IsNullOrWhiteSpace(bus_number)) || !(string.IsNullOrEmpty(bus_number)))
                        {
                            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{bus_number}"));
                            if (Cloud_Database.response.Body.ToString() != "null")
                            {
                                Bus_Data bus_Data = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

                                string bus_driver_1 = bus_Data.bus_driver_id_1;
                                string bus_driver_2 = bus_Data.bus_driver_id_2;
                                string bus_conductor = bus_Data.bus_conductor_id;

                                if (bus_driver_1.Equals(employee_id))
                                {
                                    Bus_Data bus_data = new Bus_Data()
                                    {
                                        bus_number = bus_Data.bus_number,
                                        bus_seats = bus_Data.bus_seats,
                                        bus_route = bus_Data.bus_route,
                                        bus_driver_id_1 = "",
                                        bus_driver_name_1 = "",
                                        bus_driver_id_2 = bus_Data.bus_driver_id_2,
                                        bus_driver_name_2 = bus_Data.bus_driver_name_2,
                                        bus_conductor_id = bus_Data.bus_conductor_id,
                                        bus_conductor_name = bus_Data.bus_conductor_name
                                    };
                                    Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{bus_number}", bus_data);
                                }
                                else if (bus_driver_2.Equals(employee_id))
                                {
                                    Bus_Data bus_data = new Bus_Data()
                                    {
                                        bus_number = bus_Data.bus_number,
                                        bus_seats = bus_Data.bus_seats,
                                        bus_route = bus_Data.bus_route,
                                        bus_driver_id_1 = bus_Data.bus_driver_id_1,
                                        bus_driver_name_1 = bus_Data.bus_driver_name_1,
                                        bus_driver_id_2 = "",
                                        bus_driver_name_2 = "",
                                        bus_conductor_id = bus_Data.bus_conductor_id,
                                        bus_conductor_name = bus_Data.bus_conductor_name
                                    };
                                    Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{bus_number}", bus_data);
                                }
                                else if (bus_conductor.Equals(employee_id))
                                {
                                    Bus_Data bus_data = new Bus_Data()
                                    {
                                        bus_number = bus_Data.bus_number,
                                        bus_seats = bus_Data.bus_seats,
                                        bus_route = bus_Data.bus_route,
                                        bus_driver_id_1 = bus_Data.bus_driver_id_1,
                                        bus_driver_name_1 = bus_Data.bus_driver_name_1,
                                        bus_driver_id_2 = bus_Data.bus_driver_id_2,
                                        bus_driver_name_2 = bus_Data.bus_driver_name_2,
                                        bus_conductor_id = "",
                                        bus_conductor_name = ""
                                    };
                                    Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{bus_number}", bus_data);
                                }
                            }
                        }
                        else
                        {
                            await RemoveEmployee();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task RemoveEmployee()
        {
            try
            {
                int selectedrowindex = dgvDataView.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvDataView.Rows[selectedrowindex];

                string employee_id = row.Cells[0].Value.ToString();
                string position = row.Cells[6].Value.ToString();

                Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Employee_Data/Employees/{employee_id}");
                Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Account_Data/{position}/{employee_id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private async void frmEmployee_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadData();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Cloud_Database.isConnected_TO_Internet() == true)
            {
                if (dgvDataView.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgvDataView.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvDataView.Rows[selectedrowindex];
                    string employee_id = row.Cells[0].Value.ToString();
                    string employee_name = row.Cells[1].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"Delete ID: {employee_id} Name: {employee_name}?", $"Delete ID: {employee_id}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        await UpdateBusData();
                        await RemoveEmployee();
                        await LoadData();
                    }
                }
            }
            else 
            {
                MessageBox.Show("No Internet Connection", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmAddEmployee frm_Add_Employee = new frmAddEmployee(this);
            frm_Add_Employee.ShowDialog(this);
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            frmUpdateEmployee frm_update_employee = new frmUpdateEmployee(this);
            if (dgvDataView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvDataView.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvDataView.Rows[selectedrowindex]; 

                string[] FullName = row.Cells[1].Value.ToString().Replace(",","").Split(' ');
                string FirstName = FullName[1]; string Surname = FullName[0]; string MI = FullName[2];

                frm_update_employee.pass_EmployeeID = row.Cells[0].Value.ToString();
                frm_update_employee.pass_FirstName = FirstName;
                frm_update_employee.pass_Surname = Surname;
                frm_update_employee.pass_MI = MI;
                frm_update_employee.pass_Birthday = row.Cells[2].Value.ToString();
                frm_update_employee.pass_ContactNo = row.Cells[4].Value.ToString();
                frm_update_employee.pass_Address = row.Cells[5].Value.ToString();
                frm_update_employee.pass_Position = row.Cells[6].Value.ToString();
                frm_update_employee.pass_Mode_Of_Pay = row.Cells[7].Value.ToString();
                frm_update_employee.pass_Salary = row.Cells[8].Value.ToString();
                frm_update_employee.pass_DateHired = row.Cells[9].Value.ToString();

                frm_update_employee.ShowDialog(this);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found_match = false;
            dgvDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search box is empty.", "Search Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dgvDataView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(txtSearch.Text))
                    {
                        row.Selected = true;
                        dgvDataView.CurrentCell = row.Cells[0];
                        found_match = true;
                        break;
                    }
                }
                if (found_match != true)
                {
                    MessageBox.Show("Record does not exist.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExport_Excel_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.ExportToExcel(dgvDataView, "Employess");
        }

        private void btnPositionSettings_Click(object sender, EventArgs e)
        {
            frmSalarySettings frmSalarySettings = new frmSalarySettings();
            frmSalarySettings.ShowDialog();
        }
    }
}
