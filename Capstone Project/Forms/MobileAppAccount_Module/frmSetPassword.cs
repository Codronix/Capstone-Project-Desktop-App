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
    public partial class frmUpdatePassword : Form
    {
        private string name;
        private string ID_user;
        private string position;
        private string password;
        
        public string pass_name 
        {
            get { return name; }
            set { name = value; }
        }

        public string pass_ID
        {
            get { return ID_user; }
            set { ID_user = value; }
        }

        public string pass_position
        {
            get { return position; }
            set { position = value; }
        }

        public string pass_password 
        {
            get { return password; }
            set { password = value; }
        }

        Database Cloud_Database = new Database();
        frmManageAcc form_mng_acc;

        public frmUpdatePassword(frmManageAcc frm)
        {
            InitializeComponent();
            form_mng_acc = frm;
        }

        private void frmSetPassword_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            txtName.Text = name;
            txtUser.Text = ID_user;
            txtPassword.Text = password;
        }

        private async void btnSet_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{position}/{txtUser.Text}"));
            if (Cloud_Database.response.Body.ToString() != "null") 
            {
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Account_Data/{position}/{txtUser.Text}/password", "password123");
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Users/{txtUser.Text}/Password", "password123");
                await form_mng_acc.LoadData();
                txtPassword.Text = "password123";
            }
        }
    }
}
