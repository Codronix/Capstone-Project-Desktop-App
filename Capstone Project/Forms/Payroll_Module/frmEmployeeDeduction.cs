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

namespace Capstone_Project.Forms.Payroll_Module
{
    public partial class frmEmployeeDeduction : Form
    {
        Database Cloud_Database = new Database();
        frmDeductions frm_Deductions;
        public string ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public frmEmployeeDeduction(frmDeductions frm)
        {
            InitializeComponent();
            frm_Deductions = frm;
        }
        private async Task LoadOtherDeductions()
        {
            dgvOtherDeductions.Rows.Clear();
            Cloud_Database.response = await Task.Run(()=> Cloud_Database.client.GetAsync($"Employee_Data/Employees/{txtID.Text}/Other_Deductions/"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Deductions_Data> getData = Cloud_Database.response.ResultAs<Dictionary<string, Deductions_Data>>();
                foreach (var get in getData)
                {
                    dgvOtherDeductions.Rows.Add(
                        get.Value.Date,
                        get.Value.DeductionType,
                        get.Value.Amount_Approved,
                        get.Value.MonthlyDeduction,
                        get.Value.Balance
                        );
                }
            }
        }
        private async void frmEmployeeDeduction_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            txtID.Text = ID;
            txtName.Text = Name;
            txtPosition.Text = Position;
            await LoadOtherDeductions();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Deductions_Data Other_Deductions = new Deductions_Data
            {
                Date = DateTime.Now.ToString("MM/dd/yyyy"),
                DeductionType = txtDeductionType.Text,
                Amount_Approved = txtAmount.Text,
                MonthlyDeduction = txtMonlthlyDeduction.Text,
                Balance = txtAmount.Text
            };
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.SetAsync($"Employee_Data/Employees/{txtID.Text}/Other_Deductions/{DateTime.Now.ToString("MMddyyyy")}", Other_Deductions));
            await LoadOtherDeductions();
            txtDeductionType.Clear();
            txtAmount.Clear();
            txtMonlthlyDeduction.Clear();
            MessageBox.Show("Additional Deduction Added.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
