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
    public partial class frmDeductions : Form
    {
        Database Cloud_Database = new Database();
        public frmDeductions()
        {
            InitializeComponent();
        }
        private async Task LoadEmployeeData()
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Employee_Data/Employees"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Employee_Data> getData = Cloud_Database.response.ResultAs<Dictionary<string, Employee_Data>>();
                foreach (var get in getData)
                {
                    dgvData.Rows.Add(
                        get.Value.id,
                        $"{get.Value.firstname} {get.Value.surname}",
                        get.Value.position
                        );
                }
            }
        }
        private async void frmDeductions_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadEmployeeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found_match = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search box is empty.", "Search Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(txtSearch.Text))
                    {
                        row.Selected = true;
                        dgvData.CurrentCell = row.Cells[0];
                        found_match = true;
                        break;
                    }
                }
                if (found_match != true)
                {
                    MessageBox.Show("Record does not exist.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmEmployeeDeduction frm_EmployeeDeduction = new frmEmployeeDeduction(this);
            if (dgvData.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvData.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvData.Rows[SelectedRowIndex];

                frm_EmployeeDeduction.ID = row.Cells[0].Value.ToString();
                frm_EmployeeDeduction.Name = row.Cells[1].Value.ToString();
                frm_EmployeeDeduction.Position = row.Cells[2].Value.ToString();

                frm_EmployeeDeduction.ShowDialog(this);
            }
        }

        private void btnFixedDeductions_Click(object sender, EventArgs e)
        {
            frmMonthlyFixedDeduction Form_SetMonthlyDeductions = new frmMonthlyFixedDeduction();
            Form_SetMonthlyDeductions.ShowDialog();
        }
    }
}
