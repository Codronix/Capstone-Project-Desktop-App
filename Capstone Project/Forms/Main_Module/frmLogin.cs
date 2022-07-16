using Capstone_Project.Data;
using Capstone_Project.Forms;
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
    public partial class frmLogin : Form
    {
        Database Cloud_Database = new Database();

        public frmLogin()
        {
            InitializeComponent();
        }

        private async Task Check_Database() 
        {
            try 
            {
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("System_Settings/Admin"));
                if (Cloud_Database.response.Body.ToString() == "null")
                {
                    MessageBox.Show("There is no registered Admin Account in the system yet.\nLet us create one now.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmRegisterAdmin frm_RegisterAdmin = new frmRegisterAdmin(this);
                    frm_RegisterAdmin.PASS_Button_Task = "REGISTER";
                    frm_RegisterAdmin.ShowDialog();
                }
            }
            catch 
            {
                
            }
           
        }

        private async Task Login() 
        {

            if (Cloud_Database.isConnected_TO_Internet() == true)
            {
                try
                {
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Admin/{txtUsername.Text}"));
                    if (Cloud_Database.response.Body.ToString().Equals("null"))
                    {
                        MessageBox.Show("Username does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Admin_Data admin_data = await Task.Run(() => Cloud_Database.response.ResultAs<Admin_Data>());
                        string password = admin_data.Password;
                        string Admin_Name = $"{admin_data.FirstName} {admin_data.MI} {admin_data.LastName}";
                        string Admin_ID = admin_data.Admin_ID;

                        if (password.Equals(txtPassword.Text))
                        {
                            frmMain MainForm = new frmMain();
                            MainForm.PASS_Admin_Name = Admin_Name;
                            MainForm.PASS_Admin_ID = Admin_ID;
                            MainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("No Internet Connection", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrWhiteSpace(txtUsername.Text)) &&
                (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                MessageBox.Show("Username and Password is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await Login();
            }
            //frmMain MainForm = new frmMain();
            //MainForm.Show();
            //this.Hide();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await Check_Database();
        }
    }
}
