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

namespace Capstone_Project.Forms.SystemSettings_Module
{
    public partial class frmSalarySettings : Form
    {
        Database Cloud_Database = new Database();
        public frmSalarySettings()
        {
            InitializeComponent();
        }
        private async Task LOAD_Position_Details()
        {
            string position = cbPosition.Text;
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Positions_Settings/{position}"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Positions_Data GET_Position_Details = Cloud_Database.response.ResultAs<Positions_Data>();
                cbModeOfPay.Text = GET_Position_Details.Mode_Of_Pay;
                txtSalary.Text = GET_Position_Details.Salary;
            }
        }
        private void frmSalarySettings_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
        }

        private async void btnSet_Pos_Settings_Click(object sender, EventArgs e)
        {
            string position = cbPosition.Text;
            Positions_Data positions_data = new Positions_Data()
            {
                Position = cbPosition.Text,
                Mode_Of_Pay = cbModeOfPay.Text,
                Salary = txtSalary.Text,
            };
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"System_Settings/Positions_Settings/{position}", positions_data));
            //await LoadComboBoxData();
            MessageBox.Show($"{position} position settings set.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async void btnRemovePos_Click(object sender, EventArgs e)
        {
            string position = cbPosition.Text;
            if (!(string.IsNullOrEmpty(cbPosition.Text)) || !(string.IsNullOrWhiteSpace(cbPosition.Text)))
            {
                Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"System_Settings/Positions_Settings/{position}");
                cbPosition.SelectedItem = null;
                cbModeOfPay.SelectedItem = null;
                txtSalary.Clear();
            }
        }
        private async void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LOAD_Position_Details();
        }
    }
}
