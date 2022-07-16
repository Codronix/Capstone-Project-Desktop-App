using Capstone_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    public partial class frmUpdateEmployee : Form
    {
        private string EmployeeID;
        private string FirstName;
        private string Surname;
        private string MI;
        private string Birthday;
        private string ContactNo;
        private string Address;
        private string Position;
        private string Salary;
        private string DateHired;
        private string Mode_Of_Pay;

        public string pass_EmployeeID 
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        public string pass_FirstName 
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string pass_Surname 
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public string pass_MI 
        {
            get { return MI; }
            set { MI = value; }
        }
        public string pass_Birthday 
        {
            get { return Birthday; }
            set { Birthday = value; }
        }
        public string pass_ContactNo 
        {
            get { return ContactNo; }
            set { ContactNo = value; }
        }
        public string pass_Address 
        {
            get { return Address; }
            set { Address = value; }
        }
        public string pass_Position 
        {
            get { return Position; }
            set { Position = value; }
        }
        public string pass_Mode_Of_Pay
        {
            get { return Mode_Of_Pay; }
            set { Mode_Of_Pay = value; }
        }
        public string pass_Salary 
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public string pass_DateHired 
        {
            get { return DateHired; }
            set { DateHired = value; }
        }

        Database Cloud_Database = new Database();
        frmEmployee frm_employee;

        public frmUpdateEmployee(frmEmployee frm)
        {
            InitializeComponent();
            frm_employee = frm;
        }
        private void LoadData() 
        {
            txtID.Text = EmployeeID;
            txtFirstName.Text = FirstName;
            txtSurname.Text = Surname;
            txtMI.Text = MI;
            dtpBirthdate.Value = DateTime.ParseExact(Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            txtContact.Text = ContactNo;
            txtAddress.Text = Address;
            cbPosition.Text = Position;
            txtModeOfPay.Text = Mode_Of_Pay;
            txtSalary.Text = Salary;
            dtpDateHired.Value = DateTime.ParseExact(DateHired, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }

        private async Task LOAD_ComboBox_Position_Data()
        {
            cbPosition.Items.Clear();
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Positions_Settings"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Positions_Data> GET_PositionData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Positions_Data>>());
                foreach (var get in GET_PositionData)
                {
                    cbPosition.Items.Add(
                        get.Value.Position
                        );
                }
            }
        }

        private async Task LOAD_Position_Details()
        {
            string position = cbPosition.Text;
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Positions_Settings/{position}"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Positions_Data GET_Position_Details = Cloud_Database.response.ResultAs<Positions_Data>();
                txtModeOfPay.Text = GET_Position_Details.Mode_Of_Pay;
                txtSalary.Text = GET_Position_Details.Salary;
            }
        }

        private async void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LOAD_ComboBox_Position_Data();
            LoadData();
            dtpDateHired.MaxDate = DateTime.Now.Date;
            dtpBirthdate.MaxDate = DateTime.Now.Date.AddYears(-18);
        }

        private async Task UpdateEmployeeInfo(string To_Position, string From_Position) 
        {
            try
            {
                Cloud_Database.response = await Cloud_Database.client.GetAsync($"Users/{txtID.Text}");
                UserAccounts_Data AccountData = Cloud_Database.response.ResultAs<UserAccounts_Data>();
                Employee_Data emp_data = new Employee_Data()
                {
                    id = txtID.Text,
                    firstname = txtFirstName.Text,
                    surname = txtSurname.Text,
                    mi = txtMI.Text,
                    birthday = dtpBirthdate.Text,
                    contact_num = txtContact.Text,
                    address = txtAddress.Text,
                    mode_of_pay = txtModeOfPay.Text,
                    position = cbPosition.Text,
                    salary = txtSalary.Text,
                    date_hired = dtpDateHired.Text
                };

                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{From_Position}/{txtID.Text}"));

                if (Cloud_Database.response.Body.ToString().Equals("null"))
                {
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{To_Position}/{txtID.Text}"));
                }

                Accounts_Data account_data = new Accounts_Data()
                {
                    id = txtID.Text,
                    firstname = txtFirstName.Text,
                    surname = txtSurname.Text,
                    mi = txtMI.Text,
                    contact_num = txtContact.Text,
                    assigned_to = "N/A",
                    position = cbPosition.Text,
                    password = AccountData.Password
                };
                
                UserAccounts_Data account = new UserAccounts_Data()
                {
                    ID = txtID.Text,
                    Username = txtID.Text,
                    FullName = $"{txtFirstName.Text} {txtMI.Text} {txtSurname.Text}",
                    Password = AccountData.Password,
                    Position = cbPosition.Text,
                    Email = AccountData.Email
                };

                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{From_Position}"));
                if (Cloud_Database.response.Body.ToString().Equals("null"))
                {
                    Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Employee_Data/Employees/{txtID.Text}", emp_data);
                    Cloud_Database.response = await Cloud_Database.client.SetAsync($"Account_Data/{To_Position}/{txtID.Text}", account_data);
                    Cloud_Database.response = await Cloud_Database.client.SetAsync($"Users/{txtID.Text}", account);
                    await frm_employee.LoadData();
                }
                else
                {
                    Boolean ID_Exist = false;
                    Dictionary<string, Employee_Data> result = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Employee_Data>>());
                    foreach (var get in result)
                    {
                        string employee_id_result = get.Value.id;
                        if (txtID.Text == employee_id_result)
                        {
                            ID_Exist = true;
                        }
                    }
                    if (ID_Exist == true)
                    {
                        Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Employee_Data/Employees/{txtID.Text}", emp_data);
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Account_Data/{From_Position}/{txtID.Text}");
                        Cloud_Database.response = await Cloud_Database.client.SetAsync($"Account_Data/{To_Position}/{txtID.Text}", account_data);
                        Cloud_Database.response = await Cloud_Database.client.SetAsync($"Users/{txtID.Text}", account);
                    }
                    else
                    {
                        Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Employee_Data/Employees/{txtID.Text}", emp_data);
                        Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Account_Data/{To_Position}/{txtID.Text}", account_data);
                        Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Users/{txtID.Text}", account);
                    }
                    await frm_employee.LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task UPDATE_DATA()
        {
            try
            {
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{Position}/{txtID.Text}"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Accounts_Data result = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());
                    string bus_number = result.assigned_to;

                    if (string.IsNullOrEmpty(bus_number) || string.IsNullOrWhiteSpace(bus_number))
                    {
                        await UpdateEmployeeInfo(cbPosition.Text, Position);
                    }
                    else
                    {
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{bus_number}"));
                        if (Cloud_Database.response.Body.ToString() != "null")
                        {
                            Bus_Data bus_Data = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

                            string bus_driver_1 = bus_Data.bus_driver_id_1;
                            string bus_driver_2 = bus_Data.bus_driver_id_2;
                            string bus_conductor = bus_Data.bus_conductor_id;

                            if (bus_driver_1.Equals(EmployeeID))
                            {
                                Bus_Data bus_data = new Bus_Data()
                                {
                                    bus_number = bus_Data.bus_number,
                                    bus_seats = bus_Data.bus_seats,
                                    bus_route = bus_Data.bus_route,
                                    bus_driver_id_1 = "N/A",
                                    bus_driver_name_1 = "N/A",
                                    bus_driver_id_2 = bus_Data.bus_driver_id_2,
                                    bus_driver_name_2 = bus_Data.bus_driver_name_2,
                                    bus_conductor_id = bus_Data.bus_conductor_id,
                                    bus_conductor_name = bus_Data.bus_conductor_name
                                };
                                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{bus_number}", bus_data);
                            }
                            else if (bus_driver_2.Equals(EmployeeID))
                            {
                                Bus_Data bus_data = new Bus_Data()
                                {
                                    bus_number = bus_Data.bus_number,
                                    bus_seats = bus_Data.bus_seats,
                                    bus_route = bus_Data.bus_route,
                                    bus_driver_id_1 = bus_Data.bus_driver_id_1,
                                    bus_driver_name_1 = bus_Data.bus_driver_name_1,
                                    bus_driver_id_2 = "N/A",
                                    bus_driver_name_2 = "N/A",
                                    bus_conductor_id = bus_Data.bus_conductor_id,
                                    bus_conductor_name = bus_Data.bus_conductor_name
                                };
                                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{bus_number}", bus_data);
                            }
                            else if (bus_conductor.Equals(EmployeeID))
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
                                    bus_conductor_id = "N/A",
                                    bus_conductor_name = "N/A"
                                };
                                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{ bus_number}", bus_data);
                            }
                            await UpdateEmployeeInfo(cbPosition.Text, Position);
                        }
                        else 
                        {
                            await UpdateEmployeeInfo(cbPosition.Text, Position);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UPDATE_DATA();
        }

        private async void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LOAD_Position_Details();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}