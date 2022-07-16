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
    public partial class frmBusses : Form
    {
        public frmBusses()
        {
            InitializeComponent();
        }
        Database Cloud_Database = new Database();

        public async Task LoadBusData()
        {
            dgvDataView.Rows.Clear();
            try
            {
                Cloud_Database.response = await Task.Run (() => Cloud_Database.client.GetAsync("Bus_Data/Busses/"));
                if (Cloud_Database.response.Body.ToString() != "null") 
                {
                    Dictionary<string, Bus_Data> getData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Bus_Data>>());
                    foreach (var get in getData)
                    {
                        dgvDataView.Rows.Add(
                            get.Value.bus_number,
                            get.Value.bus_seats,
                            get.Value.bus_route,
                            get.Value.bus_driver_name_1,
                            get.Value.bus_driver_id_1,
                            get.Value.bus_driver_name_2,
                            get.Value.bus_driver_id_2,
                            get.Value.bus_conductor_name,
                            get.Value.bus_conductor_id,
                            get.Value.start_time
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task Clear_Assigned_To(string Data_Path) 
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync(Data_Path));
            Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

            Accounts_Data employee_data = new Accounts_Data()
            {
                id = emp_data.id,
                firstname = emp_data.firstname,
                surname = emp_data.surname,
                mi = emp_data.mi,
                contact_num = emp_data.contact_num,
                assigned_to = "N/A",
                position = emp_data.position,
                password = emp_data.password
            };
            Cloud_Database.response = await Cloud_Database.client.UpdateAsync(Data_Path, employee_data);
        }

        public async Task DeleteRecord()
        {
            try
            {
                if (dgvDataView.SelectedCells.Count > 0)
                {
                    int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];

                    if (!(string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString())) && !(string.IsNullOrWhiteSpace(row.Cells[6].Value.ToString())) && !(string.IsNullOrWhiteSpace(row.Cells[8].Value.ToString())))
                    {
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[5].Value}");
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[7].Value}");
                        await Clear_Assigned_To($"Account_Data/Conductor/{ row.Cells[9].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else if (!(string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString())) && !(string.IsNullOrWhiteSpace(row.Cells[6].Value.ToString()))) // Driver 1 and 2
                    {
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[5].Value}");
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[7].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else if (!(string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString())) && !(string.IsNullOrWhiteSpace(row.Cells[8].Value.ToString()))) // Driver 1 and Conductor
                    {
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[5].Value}");
                        await Clear_Assigned_To($"Account_Data/Conductor/{ row.Cells[9].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else if (!(string.IsNullOrWhiteSpace(row.Cells[6].Value.ToString())) && !(string.IsNullOrWhiteSpace(row.Cells[8].Value.ToString()))) // Driver 2 and Conductor
                    {
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[7].Value}");
                        await Clear_Assigned_To($"Account_Data/Conductor/{ row.Cells[9].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else if (!(string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))) // Driver 1
                    {
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[5].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else if (!(string.IsNullOrWhiteSpace(row.Cells[6].Value.ToString()))) // Driver 2
                    {
                        await Clear_Assigned_To($"Account_Data/Driver/{ row.Cells[7].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else if (!(string.IsNullOrWhiteSpace(row.Cells[9].Value.ToString()))) // Conductor
                    {
                        await Clear_Assigned_To($"Account_Data/Conductor/{ row.Cells[9].Value}");
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                    else
                    {
                        Cloud_Database.response = await Cloud_Database.client.DeleteAsync($"Bus_Data/Busses/{row.Cells[0].Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            frmAddBusses frm_add_bus = new frmAddBusses(this);
            frm_add_bus.ShowDialog(this);
        }

        private async void frmBusses_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadBusData();
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            frmUpdateBusses frm_update_bus = new frmUpdateBusses(this);
            if (dgvDataView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];

                frm_update_bus.pass_bus_number = row.Cells[0].Value.ToString();
                frm_update_bus.pass_bus_sits = row.Cells[1].Value.ToString();
                frm_update_bus.pass_bus_route = row.Cells[2].Value.ToString();
                frm_update_bus.pass_driver_name_1 = row.Cells[3].Value.ToString();
                frm_update_bus.pass_driver_id_1 = row.Cells[4].Value.ToString();
                frm_update_bus.pass_driver_name_2 = row.Cells[5].Value.ToString();
                frm_update_bus.pass_driver_id_2 = row.Cells[6].Value.ToString();
                frm_update_bus.pass_conductor_name = row.Cells[7].Value.ToString();
                frm_update_bus.pass_conductor_id = row.Cells[8].Value.ToString();
                frm_update_bus.pass_start_time = row.Cells[9].Value.ToString();
                frm_update_bus.ShowDialog(this);
            }
        }
        
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDataView.SelectedCells.Count > 0) 
            {
                int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];
                frmUpdateBusses frm_update = new frmUpdateBusses(this);

                string bus = "Bus Number: " + row.Cells[0].Value.ToString() + " Route: " + row.Cells[2].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Delete " + bus +" ?","Delete Bus " + row.Cells[0].Value.ToString(), MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if (dialogResult == DialogResult.Yes)
                {
                    await DeleteRecord();
                    await LoadBusData();
                }
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
            export.ExportToExcel(dgvDataView, "Busses");
        }
    }
}
