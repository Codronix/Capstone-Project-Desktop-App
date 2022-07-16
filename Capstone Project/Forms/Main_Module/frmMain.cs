using Capstone_Project.Forms;
using Capstone_Project.Forms.Inspector_Module;
using Capstone_Project.Forms.SystemSettings_Module;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string Name;
        private string Admin_ID;

        public string PASS_Admin_Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string PASS_Admin_ID 
        {
            get { return Admin_ID; }
            set { Admin_ID = value; }
        }

        private Form activeForm;
        Database Cloud_Database = new Database();

        private void OpenChildForm(Form childForm, Object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktopPane.Controls.Add(childForm);
            this.pnlDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDigitalClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblName.Text = Name;
            lblAdminID.Text = Admin_ID;
            btnBusTripRec.PerformClick();
        }

        private async void btnEmployees_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Cloud_Database.client.GetAsync($"System_Settings/Positions_Settings");
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                btnEmployees.BackColor = Color.FromArgb(0, 122, 244);
                btnBusses.BackColor = Color.FromArgb(0, 102, 204);
                btnAccounts.BackColor = Color.FromArgb(0, 102, 204);
                btnBusTripRec.BackColor = Color.FromArgb(0, 102, 204);
                btnPayroll.BackColor = Color.FromArgb(0, 102, 204);
                btnBookers.BackColor = Color.FromArgb(0, 102, 204);
                btnInspector.BackColor = Color.FromArgb(0, 102, 204);
                OpenChildForm(new frmEmployee(), sender);
            }
            else
            {
                frmSalarySettings frmSalarySettings = new frmSalarySettings();
                MessageBox.Show("There is still no positions for employees set. Let's add some now.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmSalarySettings.ShowDialog();
            }
        }

        private void btnBusses_Click(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(0, 102, 204);
            btnBusses.BackColor = Color.FromArgb(0, 122, 244);
            btnAccounts.BackColor = Color.FromArgb(0, 102, 204);
            btnBusTripRec.BackColor = Color.FromArgb(0, 102, 204);
            btnPayroll.BackColor = Color.FromArgb(0, 102, 204);
            btnBookers.BackColor = Color.FromArgb(0, 102, 204);
            btnInspector.BackColor = Color.FromArgb(0, 102, 204);
            OpenChildForm(new frmBusses(), sender);
        }

        private void btnDriverAcc_Click(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(0, 102, 204);
            btnBusses.BackColor = Color.FromArgb(0, 102, 204);
            btnAccounts.BackColor = Color.FromArgb(0, 122, 244);
            btnBusTripRec.BackColor = Color.FromArgb(0, 102, 204);
            btnPayroll.BackColor = Color.FromArgb(0, 102, 204);
            btnBookers.BackColor = Color.FromArgb(0, 102, 204);
            btnInspector.BackColor = Color.FromArgb(0, 102, 204);
            OpenChildForm(new frmManageAcc(), sender);
        }

        private void btnBusTripRec_Click(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(0, 102, 204);
            btnBusses.BackColor = Color.FromArgb(0, 102, 204);
            btnAccounts.BackColor = Color.FromArgb(0, 102, 204);
            btnBusTripRec.BackColor = Color.FromArgb(0, 122, 244);
            btnPayroll.BackColor = Color.FromArgb(0, 102, 204);
            btnBookers.BackColor = Color.FromArgb(0, 102, 204);
            btnInspector.BackColor = Color.FromArgb(0, 102, 204);
            OpenChildForm(new frmBusTripRecords(), sender);
        }
 
        private async void btnPayroll_Click(object sender, EventArgs e)
        {
            bool QuotaSettings_Set = false;
            bool ViolationsSettings_Set = false;
            Cloud_Database.response = await Cloud_Database.client.GetAsync($"System_Settings/Quota_Settings");
            if (Cloud_Database.response.Body.ToString() == "null")
            {
                QuotaSettings_Set = false;
            }
            else
            {
                QuotaSettings_Set = true;
            }
            Cloud_Database.response = await Cloud_Database.client.GetAsync($"System_Settings/Violation_Settings");
            if (Cloud_Database.response.Body.ToString() == "null")
            {
                ViolationsSettings_Set = false;
            }
            else
            {
                ViolationsSettings_Set = true;
            }
            if (QuotaSettings_Set && ViolationsSettings_Set)
            {
                btnEmployees.BackColor = Color.FromArgb(0, 102, 204);
                btnBusses.BackColor = Color.FromArgb(0, 102, 204);
                btnAccounts.BackColor = Color.FromArgb(0, 102, 204);
                btnBusTripRec.BackColor = Color.FromArgb(0, 102, 204);
                btnPayroll.BackColor = Color.FromArgb(0, 122, 244);
                btnBookers.BackColor = Color.FromArgb(0, 102, 204);
                btnInspector.BackColor = Color.FromArgb(0, 102, 204);
                OpenChildForm(new frmPayrollRecords(), sender);
            }
            else
            {
                MessageBox.Show("Let's setup the incentive of drivers and conductors.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuotaSettings frmQuotaSettings = new frmQuotaSettings();
                frmQuotaSettings.ShowDialog();
            }
        }

        private void btnBookers_Click(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(0, 102, 204);
            btnBusses.BackColor = Color.FromArgb(0, 102, 204);
            btnAccounts.BackColor = Color.FromArgb(0, 102, 204);
            btnBusTripRec.BackColor = Color.FromArgb(0, 102, 204);
            btnPayroll.BackColor = Color.FromArgb(0, 102, 204);
            btnBookers.BackColor = Color.FromArgb(0, 122, 244);
            btnInspector.BackColor = Color.FromArgb(0, 102, 204);
            OpenChildForm(new frmBookers(), sender);
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm_login = new frmLogin();
            frm_login.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSystemSettings frm_SystemSettings = new frmSystemSettings();
            frm_SystemSettings.ShowDialog();
        }

        private void btnInspector_Click(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(0, 102, 204);
            btnBusses.BackColor = Color.FromArgb(0, 102, 204);
            btnAccounts.BackColor = Color.FromArgb(0, 102, 204);
            btnBusTripRec.BackColor = Color.FromArgb(0, 102, 204);
            btnPayroll.BackColor = Color.FromArgb(0, 102, 204);
            btnBookers.BackColor = Color.FromArgb(0, 102, 204);
            btnInspector.BackColor = Color.FromArgb(0, 122, 244);
            OpenChildForm(new frmInspector(), sender);
        }
    }
}
