using Capstone_Project.Data;
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

namespace Capstone_Project.Forms
{
    public partial class frmSystemSettings : Form
    {
        Database Cloud_Database = new Database();

        public frmSystemSettings()
        {
            InitializeComponent();
        }
        public async Task LoadData()
        {
            dgvData.Rows.Clear();
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("System_Settings/Admin/"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Admin_Data> GET_AdminData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Admin_Data>>());
                foreach (var get in GET_AdminData)
                {
                    dgvData.Rows.Add(
                        get.Value.Admin_ID,
                        $"{get.Value.FirstName} {get.Value.MI} {get.Value.LastName}",
                        get.Value.Password
                        );
                }
            }
        }
        private async void frmSystemSettings_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadData();
        }
        private void btnAdd_Admin_Click(object sender, EventArgs e)
        {
            frmRegisterAdmin frm_RegisterAdmin = new frmRegisterAdmin(this);
            frm_RegisterAdmin.PASS_Button_Task = "Register";
            frm_RegisterAdmin.ShowDialog();
        }
        private void btnUpdate_Admin_Click(object sender, EventArgs e)
        {
            frmRegisterAdmin frm_RegisterAdmin = new frmRegisterAdmin(this);
            if (dgvData.SelectedCells.Count > 0) 
            {
                int SelectedRowIndex = dgvData.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvData.Rows[SelectedRowIndex];

                string[] Name = row.Cells[1].Value.ToString().Split(' ');

                frm_RegisterAdmin.PASS_Admin_ID = row.Cells[0].Value.ToString();
                frm_RegisterAdmin.PASS_First_Name = Name[0];
                frm_RegisterAdmin.PASS_MI = Name[1];
                frm_RegisterAdmin.PASS_Last_Name = Name[2];
                frm_RegisterAdmin.PASS_Password = row.Cells[2].Value.ToString();
                frm_RegisterAdmin.PASS_Button_Task = "Update";

                frm_RegisterAdmin.ShowDialog();
            }
        }
        private async void btnRemove_Admin_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvData.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvData.Rows[SelectedRowIndex];

                DialogResult dialogResult = MessageBox.Show($"Delete {row.Cells[0].Value}: {row.Cells[1].Value}", $"Delete System Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Cloud_Database.response = await Task.Run(() => Cloud_Database.client.DeleteAsync($"System_Settings/Admin/{row.Cells[0].Value}"));
                    await LoadData();
                }
            }
        }

        private void tbnSnRDiscount_Click(object sender, EventArgs e)
        {
            frmSystemDiscount frmDiscount = new frmSystemDiscount();
            frmDiscount.ShowDialog();
        }
    }
}
