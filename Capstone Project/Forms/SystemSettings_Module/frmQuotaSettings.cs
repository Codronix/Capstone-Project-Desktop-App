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
    public partial class frmQuotaSettings : Form
    {
        Database Cloud_Database = new Database();
        public frmQuotaSettings()
        {
            InitializeComponent();
        }
        private async Task LOAD_Quota_Details()
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"System_Settings/Quota_Settings"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Quota_Data GET_Quota_Details = Cloud_Database.response.ResultAs<Quota_Data>();
                txtLowQuota.Text = GET_Quota_Details.Low_Quota;
                txtLow_AdditionalPay.Text = GET_Quota_Details.Low_Quota_AddPay;
                txtHighQuota.Text = GET_Quota_Details.High_Quota;
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
        private async void frmQuotaAndViolationSettings_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LOAD_Quota_Details();
            await LOAD_Violation_Details();
        }

        private async void btnSetSettings_Click(object sender, EventArgs e)
        {
            Quota_Data quota_data = new Quota_Data()
            {
                Low_Quota = txtLowQuota.Text,
                Low_Quota_AddPay = txtLow_AdditionalPay.Text,
                High_Quota = txtHighQuota.Text,
                High_Quota_AddPay = txtHigh_AdditionalPay.Text
            };
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"System_Settings/Quota_Settings", quota_data));
            TrafficViolation_Data trafficViolation_Data = new TrafficViolation_Data()
            {
                Violation_None = txtZeroViolations.Text,
                Violation_One = txtOneViolations.Text,
                Violation_Two = txtTwoViolations.Text
            };
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"System_Settings/Violation_Settings", trafficViolation_Data));
            MessageBox.Show("Settings Set.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtLowQuota_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLow_AdditionalPay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHighQuota_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHigh_AdditionalPay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtZeroViolations_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOneViolations_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTwoViolations_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
