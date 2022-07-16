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

namespace Capstone_Project.Forms
{
    public partial class frmRegisterAdmin : Form
    {
        Database Cloud_Database = new Database();
        frmSystemSettings frm_SystemSettings;
        frmLogin frm_Login;

        private string Admin_ID;
        private string First_Name;
        private string Last_Name;
        private string MI;
        private string Password;
        private string Button_Task;

        public string PASS_Admin_ID
        {
            get { return Admin_ID; }
            set { Admin_ID = value; }
        }

        public string PASS_First_Name
        {
            get { return First_Name; }
            set { First_Name = value; }
        }

        public string PASS_Last_Name
        {
            get { return Last_Name; }
            set { Last_Name = value; }
        }

        public string PASS_MI
        {
            get { return MI; }
            set { MI = value; }
        }

        public string PASS_Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string PASS_Button_Task
        {
            get { return Button_Task; }
            set { Button_Task = value; }
        }

        public frmRegisterAdmin(Form frm)
        {
            InitializeComponent();

            if (Application.OpenForms.OfType<frmSystemSettings>().Any())
            {
                frm_SystemSettings = (frmSystemSettings)frm;
            }
            else if (Application.OpenForms.OfType<frmLogin>().Any()) 
            {
                frm_Login = (frmLogin)frm;
            }
        }

        public void GenerateID()
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
            txtID.Text = "ADMIN" + otp;
        }

        private async Task Register_Admin()
        {
            Admin_Data admin_data = new Admin_Data()
            {
                Admin_ID = txtID.Text,
                FirstName = txtFirstName.Text,
                LastName = txtSurname.Text,
                MI = txtMI.Text,
                Password = txtPassword.Text
            };
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"System_Settings/Admin/{txtID.Text}", admin_data));
        }

        private void LoadData() 
        {
            btnRegister.Text = Button_Task;

            if (btnRegister.Text.Equals("Update", StringComparison.OrdinalIgnoreCase))
            {
                txtID.Text = Admin_ID;
                txtFirstName.Text = First_Name;
                txtSurname.Text = Last_Name;
                txtMI.Text = MI;
                txtPassword.Text = Password;
            }
            else if(btnRegister.Text.Equals("Register", StringComparison.OrdinalIgnoreCase))
            {
                GenerateID();
            }
        }

        private void frmRegisterAdmin_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            LoadData();
        }

        private async void btnRegister_Click(object sender, EventArgs e) 
        {
            if (btnRegister.Text.Equals("Update", StringComparison.OrdinalIgnoreCase))
            {
                if ((!(string.IsNullOrEmpty(txtID.Text)) || !(string.IsNullOrWhiteSpace(txtID.Text))) &&
                (!(string.IsNullOrEmpty(txtFirstName.Text)) || !(string.IsNullOrWhiteSpace(txtFirstName.Text))) &&
                (!(string.IsNullOrEmpty(txtSurname.Text)) || !(string.IsNullOrWhiteSpace(txtSurname.Text))) &&
                (!(string.IsNullOrEmpty(txtMI.Text)) || !(string.IsNullOrWhiteSpace(txtMI.Text))) &&
                (!(string.IsNullOrEmpty(txtPassword.Text)) || !(string.IsNullOrWhiteSpace(txtPassword.Text))))
                {
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Admin/{txtID.Text}"));
                    if (Cloud_Database.response.Body.ToString() != "null")
                    {
                        await Register_Admin();
                        await frm_SystemSettings.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnRegister.Text.Equals("Register", StringComparison.OrdinalIgnoreCase))
            {
                if ((!(string.IsNullOrEmpty(txtID.Text)) || !(string.IsNullOrWhiteSpace(txtID.Text))) &&
                (!(string.IsNullOrEmpty(txtFirstName.Text)) || !(string.IsNullOrWhiteSpace(txtFirstName.Text))) &&
                (!(string.IsNullOrEmpty(txtSurname.Text)) || !(string.IsNullOrWhiteSpace(txtSurname.Text))) &&
                (!(string.IsNullOrEmpty(txtMI.Text)) || !(string.IsNullOrWhiteSpace(txtMI.Text))) &&
                (!(string.IsNullOrEmpty(txtPassword.Text)) || !(string.IsNullOrWhiteSpace(txtPassword.Text))))
                {
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Admin/{txtID.Text}"));
                    if (Cloud_Database.response.Body.ToString().Equals("null"))
                    {
                        await Register_Admin();
                        if (Application.OpenForms.OfType<frmSystemSettings>().Any())
                        {
                            await frm_SystemSettings.LoadData();
                        }
                        MessageBox.Show("Admin Account Registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        GenerateID();
                        await Register_Admin();
                        if (Application.OpenForms.OfType<frmSystemSettings>().Any())
                        {
                            await frm_SystemSettings.LoadData();
                        }
                        MessageBox.Show("Admin Account Registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
