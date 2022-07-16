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
    public partial class frmAddEmployee : Form
    {
        Database Cloud_Database = new Database();
   
        frmEmployee frm_employee;

        public frmAddEmployee(frmEmployee frm)
        {
            InitializeComponent();
            frm_employee = frm;
        }
        public void generateID()
        {
            string num = "1234567890";
            int len = num.Length;
            string otp = string.Empty;
            int otpDigit = 4;
            string finaldigit;

            int getindex;
            for (int i = 0; i < otpDigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (otp.IndexOf(finaldigit) != -1);

                otp += finaldigit;
            }
            txtID.Text = "KLN" + otp;
        }

        public void clear_fields()
        {
            txtFirstName.Clear();
            txtSurname.Clear();
            txtMI.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task LOAD_ComboBox_Position_Data()
        {
            cbPosition.Items.Clear();
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("System_Settings/Positions_Settings/"));
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

        public async Task INSERT_DATA() 
        {
            try
            {
                Employee_Data emp_data = new Employee_Data()
                {
                    id = txtID.Text,
                    firstname = txtFirstName.Text,
                    surname = txtSurname.Text,
                    mi = txtMI.Text,
                    birthday = dtpBirthdate.Text,
                    contact_num = txtContact.Text,
                    address = txtAddress.Text,
                    position = cbPosition.Text,
                    mode_of_pay = txtModeOfPay.Text,
                    salary = txtSalary.Text,
                    date_hired = dtpDateHired.Text
                };
                Accounts_Data driver_conductor_data = new Accounts_Data()
                {
                    id = txtID.Text,
                    firstname = txtFirstName.Text,
                    surname = txtSurname.Text,
                    mi = txtMI.Text,
                    contact_num = txtContact.Text,
                    assigned_to = "N/A",
                    position = cbPosition.Text,
                    password = dtpBirthdate.Text.Replace("/", "")
                };
                UserAccounts_Data account = new UserAccounts_Data()
                {
                    ID = txtID.Text,
                    Username = txtID.Text,
                    FullName = $"{txtFirstName.Text} {txtMI.Text} {txtSurname.Text}",
                    Password = dtpBirthdate.Text.Replace("/", ""),
                    Position = cbPosition.Text,
                    Email = "",
                };
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Employee_Data/Employees/{txtID.Text}", emp_data);
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Account_Data/{cbPosition.Text}/{txtID.Text}", driver_conductor_data);
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Users/{txtID.Text}", account);
                await frm_employee.LoadData();
                clear_fields();
                generateID();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task Register_Employee() 
        {
            try
            {
                Boolean isMatch = false;

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtMI.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtSalary.Text) || string.IsNullOrWhiteSpace(cbPosition.Text))
                {
                    MessageBox.Show("Complete Required Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Employee_Data/Employees"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        Dictionary<string, Employee_Data> result = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Employee_Data>>());
                        foreach (var get in result)
                        {
                            string employee_id_result = get.Value.id;
                            if (txtID.Text == employee_id_result)
                            {
                                isMatch = true;
                            }
                        }
                        if (isMatch == false)
                        {
                            await INSERT_DATA();
                        }
                        else
                        {
                            generateID();
                            MessageBox.Show("A Matching ID was found so we generated a new one. Please Try again.", "Matching ID Found.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        await INSERT_DATA();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void frmAddEmployee_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LOAD_ComboBox_Position_Data();
            generateID();
            dtpDateHired.MaxDate = DateTime.Now.Date;
            dtpBirthdate.MaxDate = DateTime.Now.AddYears(-18);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await Register_Employee();
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
