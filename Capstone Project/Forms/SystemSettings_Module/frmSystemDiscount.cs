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
    public partial class frmSystemDiscount : Form
    {
        Database Cloud_Database = new Database();
        public frmSystemDiscount()
        {
            InitializeComponent();
        }

        private async void btnSetSeniorDiscount_Click(object sender, EventArgs e)
        {
            SeniorCitizenDiscount_Data Senior_Discount = new SeniorCitizenDiscount_Data
            {
                Senior_Discount = txtSeniorDiscount.Text
            };
            if (!string.IsNullOrEmpty(txtSeniorDiscount.Text) || !string.IsNullOrWhiteSpace(txtSeniorDiscount.Text))
            {
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"System_Settings/Senior_Discount", Senior_Discount);
                MessageBox.Show($"Senior Citizen Discount Set.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void frmSystemDiscount_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            Cloud_Database.response = await Cloud_Database.client.GetAsync($"System_Settings/Senior_Discount/");
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                SeniorCitizenDiscount_Data Senior_Discount = Cloud_Database.response.ResultAs<SeniorCitizenDiscount_Data>();
                txtSeniorDiscount.Text = Senior_Discount.Senior_Discount;
            }
        }
    }
}
