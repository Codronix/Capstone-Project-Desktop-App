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

namespace Capstone_Project.Forms.Inspector_Module
{
    public partial class frmInspector : Form
    {
        Database Cloud_Database = new Database();
        public frmInspector()
        {
            InitializeComponent();
        }

        private async void frmInspector_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadData();
        }
        public async Task LoadData()
        {
            try
            {
                dgvDataView.Rows.Clear();
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Account_Data/Inspector/"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Dictionary<string, Accounts_Data> emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Accounts_Data>>());
                    foreach (var get in emp_data)
                    {
                        dgvDataView.Rows.Add(
                            get.Value.id,
                            get.Value.surname + ", " + get.Value.firstname + " " + get.Value.mi,
                            get.Value.contact_num,
                            get.Value.assigned_to
                            );
                    }
                }
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDataView.SelectedCells.Count > 0)
            {
                frmSetInspectorLocation frm_set_inspector_location = new frmSetInspectorLocation(this);
                int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];

                frm_set_inspector_location.pass_employeeID = row.Cells[0].Value.ToString();
                frm_set_inspector_location.pass_employeeName = row.Cells[1].Value.ToString();
                frm_set_inspector_location.pass_Assigned_Location = row.Cells[3].Value.ToString();

                frm_set_inspector_location.ShowDialog(this);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found_match = false;
            dgvDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text) || string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("Search box is empty.", "Search Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvDataView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(txtSearch.Text))
                        {
                            row.Selected = true;
                            dgvDataView.CurrentCell = row.Cells[0];
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExport_Excel_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.ExportToExcel(dgvDataView, "Bookers");
        }
    }
}
