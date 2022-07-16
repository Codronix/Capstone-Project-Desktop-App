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

namespace Capstone_Project
{
    public partial class frmManageAcc : Form
    {
        Database Cloud_Databse = new Database();

        public frmManageAcc()
        {
            InitializeComponent();
        }

        public async Task LoadData() 
        {
            dgvDataView.Rows.Clear();
            string Position = cbPositions.Text;
            try
            {
                Cloud_Databse.response = await Task.Run(() => Cloud_Databse.client.GetAsync($"Account_Data/{Position}"));
                if (Cloud_Databse.response.Body.ToString() != "null") 
                {
                    Dictionary<string, Accounts_Data> getData = await Task.Run(() => Cloud_Databse.response.ResultAs<Dictionary<string, Accounts_Data>>());
                    foreach (var get in getData)
                    {
                        dgvDataView.Rows.Add(
                                get.Value.surname + ", " + get.Value.firstname + " " + get.Value.mi,
                                get.Value.contact_num,
                                get.Value.assigned_to,
                                get.Value.id,
                                get.Value.password
                        );
                    }
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Export_Excel()
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = cbPositions.Text + " Phone App Accounts";
            sf.Filter = "Excel Documents (*.xlsx)|*.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {

                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                //app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = cbPositions.Text +" Phone App Accounts";

                // storing header part in Excel  
                for (int i = 1; i < dgvDataView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDataView.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvDataView.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDataView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDataView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(sf.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
        }

        private void frmManageAcc_Load(object sender, EventArgs e)
        {
            Cloud_Databse.Cloud_DB_Connect();
            cbPositions.SelectedIndex = 0;
        }

        private async void cbmChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadData();
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
                        if (row.Cells[3].Value.ToString().Equals(txtSearch.Text))
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
            export.ExportToExcel(dgvDataView, $"{cbPositions.Text} Phone App Accounts");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDataView.SelectedCells.Count > 0)
                {
                    int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];
                    frmUpdatePassword frm = new frmUpdatePassword(this);

                    frm.pass_ID = row.Cells[3].Value.ToString();
                    frm.pass_name = row.Cells[0].Value.ToString();
                    frm.pass_password = row.Cells[4].Value.ToString();
                    frm.pass_position = cbPositions.Text;
                    frm.ShowDialog(this);
                }
            }
            catch
            {
                if (dgvDataView.SelectedCells.Count > 0)
                {
                    int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];
                    frmUpdatePassword frm = new frmUpdatePassword(this);

                    frm.pass_ID = row.Cells[3].Value.ToString();
                    frm.pass_name = row.Cells[0].Value.ToString();
                    frm.pass_position = cbPositions.Text;
                    frm.ShowDialog(this);
                }
            }
        }
    }
}
