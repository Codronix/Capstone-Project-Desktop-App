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
    public partial class frmMonthlyFixedDeduction : Form
    {
        Database Cloud_Database = new Database();
        public frmMonthlyFixedDeduction()
        {
            InitializeComponent();
        }
        private async Task LoadDeductions()
        {
            dgvMonthlyDeductions.Rows.Clear();
            Cloud_Database.response = await Cloud_Database.client.GetAsync($"Deductions_Data");
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Deductions_Data> getData = Cloud_Database.response.ResultAs<Dictionary<string, Deductions_Data>>();
                foreach (var get in getData)
                {
                    dgvMonthlyDeductions.Rows.Add(
                        get.Value.DeductionType,
                        get.Value.MonthlyDeduction
                        );
                }
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDeductionType.Text) || !string.IsNullOrWhiteSpace(txtDeductionType.Text)
                || !string.IsNullOrEmpty(txtDeductionAmount.Text) || !string.IsNullOrWhiteSpace(txtDeductionAmount.Text))
            {
                Deductions_Data MonthlyDeductions = new Deductions_Data
                {
                    DeductionType = txtDeductionType.Text,
                    MonthlyDeduction = txtDeductionAmount.Text
                };
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Deductions_Data/{txtDeductionType.Text}", MonthlyDeductions);
                await LoadDeductions();
                txtDeductionType.Clear();
                txtDeductionAmount.Clear();
                MessageBox.Show("Fixed Monthly Deductions Added.", "Added Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fields are empty. Cannot add.", "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void frmMonthlyFixedDeduction_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadDeductions();
        }
        private void dgvMonthlyDeductions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMonthlyDeductions.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvMonthlyDeductions.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvMonthlyDeductions.Rows[SelectedRowIndex];

                txtDeductionType.Text = row.Cells[0].Value.ToString();
                txtDeductionAmount.Text = row.Cells[1].Value.ToString();
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDeductionType.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"Would you like to delete {txtDeductionType} Deduction?","Confirm Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Deductions_Data/{txtDeductionType.Text}");
                    txtDeductionType.Clear();
                    txtDeductionAmount.Clear();
                    await LoadDeductions();
                }
            }
        }

        private void txtDeductionAmount_KeyPress(object sender, KeyPressEventArgs e)
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
