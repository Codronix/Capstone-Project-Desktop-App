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
    public partial class frmAddBusses : Form
    {
        Database Cloud_Database = new Database();
        frmBusses frm_busses;

        public frmAddBusses(frmBusses frm)
        {
            InitializeComponent();
            frm_busses = frm;
        }

        public async Task LoadEmpData()
        {
            string position = cbmPosition.Text;
            dgvChoices.Rows.Clear();
            try
            {
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.Get($"Account_Data/{position}"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Dictionary<string, Accounts_Data> getData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Accounts_Data>>());
                    foreach (var get in getData)
                    {
                        if (get.Value.assigned_to.Equals("N/A"))
                        {
                            dgvChoices.Rows.Add(
                                get.Value.id,
                                get.Value.firstname + " " + get.Value.surname
                                );
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (cbmPosition.Text.Equals("Driver"))
                    {
                        lblDriverNum.Visible = true;
                        cbmDriverNum.Visible = true;
                        cbmDriverNum.SelectedIndex = 0;
                    }
                    else if (cbmPosition.Text.Equals("Conductor"))
                    {
                        lblDriverNum.Visible = false;
                        cbmDriverNum.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ClearFields() 
        {
            txtBusNumber.Clear();
            txtBusSits.Clear();
            txtBusRoute.Clear();
            txtDriverID_1.Clear();
            txtDriverName_1.Clear();
            txtDriverID_2.Clear();
            txtDriverName_2.Clear();
            txtConductorID.Clear();
            txtConductorName.Clear();
        }
        private void frmAddBusses_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            cbmPosition.SelectedIndex = 0;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            Bus_Data bus_data = new Bus_Data()
            {
                bus_number = txtBusNumber.Text,
                bus_seats = txtBusSits.Text,
                bus_route = txtBusRoute.Text,
                start_time = dtpScheduleFrom.Text,
                bus_driver_id_1 = txtDriverID_1.Text,
                bus_driver_name_1 = txtDriverName_1.Text,
                bus_driver_id_2 = txtDriverID_2.Text,
                bus_driver_name_2 = txtDriverName_2.Text,
                bus_conductor_id = txtConductorID.Text,
                bus_conductor_name = txtConductorName.Text
            };

            if (string.IsNullOrWhiteSpace(txtBusNumber.Text) || string.IsNullOrWhiteSpace(txtBusSits.Text)
               || string.IsNullOrWhiteSpace(txtBusRoute.Text))
            {
                MessageBox.Show("Bus number, Bus Seats, Bus Route, and Bus Fare cannot be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean match_found = false;
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Bus_Data/Busses"));
                if (Cloud_Database.response.Body.ToString() != "null")
                {
                    Dictionary<string, Bus_Data> result = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Bus_Data>>());
                    foreach (var get in result)
                    {
                        string bus_number = get.Value.bus_number;
                        if (txtBusNumber.Text == bus_number)
                        {
                            match_found = true;
                        }
                    }
                }

                if (match_found == true)
                {
                    MessageBox.Show("Bus Number already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtDriverID_1.Text))
                    {
                        Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data);
                    }
                    else
                    {
                        //Search Driver ID 1
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.Get($"Account_Data/Driver/{txtDriverID_1.Text}"));
                        if (Cloud_Database.response.Body.ToString() != "null")
                        {
                            Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

                            //Update Driver Account Data
                            Accounts_Data driver_data_1 = new Accounts_Data()
                            {
                                id = emp_data.id,
                                firstname = emp_data.firstname,
                                surname = emp_data.surname,
                                mi = emp_data.mi,
                                contact_num = emp_data.contact_num,
                                assigned_to = txtBusNumber.Text,
                                position = emp_data.position,
                                password = emp_data.password

                            };

                            Cloud_Database.response = await Cloud_Database.client.SetAsync($"Account_Data/Driver/{txtDriverID_1.Text}", driver_data_1);
                            Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data);
                        }

                    }

                    if (string.IsNullOrWhiteSpace(txtDriverID_2.Text))
                    {
                        Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data);
                    }
                    else
                    {
                        //Search Driver ID 2
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.Get($"Account_Data/Driver/{txtDriverID_2.Text}"));
                        if (Cloud_Database.response.Body.ToString() != "null")
                        {
                            Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

                            //Update Driver Account Data
                            Accounts_Data driver_data_2 = new Accounts_Data()
                            {
                                id = emp_data.id,
                                firstname = emp_data.firstname,
                                surname = emp_data.surname,
                                mi = emp_data.mi,
                                contact_num = emp_data.contact_num,
                                assigned_to = txtBusNumber.Text,
                                position = emp_data.position,
                                password = emp_data.password
                            };

                            Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Account_Data/Driver/{txtDriverID_2.Text}", driver_data_2);
                            Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data);
                        }

                    }

                    if (string.IsNullOrWhiteSpace(txtConductorID.Text))
                    {
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.Set($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data));
                    }
                    else
                    {
                        //Search Conductor ID
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.Get($"Account_Data/Conductor/{txtConductorID.Text}"));
                        if (Cloud_Database.response.Body.ToString() != "null")
                        {
                            Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

                            //Update Conductor Account Data
                            Accounts_Data conductor_data = new Accounts_Data()
                            {
                                id = emp_data.id,
                                firstname = emp_data.firstname,
                                surname = emp_data.surname,
                                mi = emp_data.mi,
                                contact_num = emp_data.contact_num,
                                assigned_to = txtBusNumber.Text,
                                position = emp_data.position,
                                password = emp_data.password
                            };
                            Cloud_Database.response = await Cloud_Database.client.SetAsync($"Account_Data/Conductor/{txtConductorID.Text}", conductor_data);
                            Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data);
                        }

                    }
                    await LoadEmpData();
                    // INSERT BUS PASSENGER FARE LIST HERE <<<<<<<<<<<<<<<<<<<<<<<<
                    foreach (DataGridViewRow row in dgvPassengerFareList.Rows)
                    {
                        Bus_Data PassengerFareList = new Bus_Data
                        {
                            bus_stop = row.Cells[0].Value.ToString(),
                            bus_fare = row.Cells[1].Value.ToString()
                        };
                        Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}/PassengerFareList/{row.Cells[0].Value.ToString()}", PassengerFareList);
                    }
                    dgvPassengerFareList.Rows.Clear();
                    await frm_busses.LoadBusData();
                    ClearFields();
                    MessageBox.Show("Bus Added.","Add Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void txtDriverID_1_TextChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow rows in dgvChoices.Rows)
            //{
            //    if (txtDriverID_1.Text.Equals(rows.Cells[0].Value.ToString()) || txtDriverID_2.Text.Equals(rows.Cells[0].Value.ToString()) || txtConductorID.Text.Equals(rows.Cells[0].Value.ToString()))
            //    {
            //        dgvChoices.Rows.Remove(rows);
            //    }
            //}
        }

        private void txtDriverID_2_TextChanged(object sender, EventArgs e)
        {
            //LoadEmpData();
        }

        private void txtConductorID_TextChanged(object sender, EventArgs e)
        {
            //LoadEmpData();
        }
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArea.Text) || !string.IsNullOrEmpty(txtFare.Text) || !string.IsNullOrWhiteSpace(txtArea.Text) || !string.IsNullOrWhiteSpace(txtFare.Text))
            {
                this.dgvPassengerFareList.Rows.Add(
                txtArea.Text,
                txtFare.Text
                );
                txtArea.Clear();
                txtFare.Clear();
            }
        }

        private async void cbmPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadEmpData();
        }

        private void dgvChoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgvChoices.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvChoices.Rows[selectedrowindex];
            try
            {
                if (dgvChoices.SelectedCells.Count > 0)
                {
                    if (cbmPosition.Text.Equals("Driver"))
                    {
                        if (cbmDriverNum.Text.Equals("1"))
                        {
                            txtDriverID_1.Text = row.Cells[0].Value.ToString();
                            txtDriverName_1.Text = row.Cells[1].Value.ToString();

                        }
                        else if (cbmDriverNum.Text.Equals("2"))
                        {
                            txtDriverID_2.Text = row.Cells[0].Value.ToString();
                            txtDriverName_2.Text = row.Cells[1].Value.ToString();
                        }
                    }
                    else if (cbmPosition.Text.Equals("Conductor"))
                    {
                        txtConductorID.Text = row.Cells[0].Value.ToString();
                        txtConductorName.Text = row.Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClearPassengerFareList_Click(object sender, EventArgs e)
        {
            dgvPassengerFareList.Rows.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dgvPassengerFareList.SelectedRows.Count > 0)
            {
                dgvPassengerFareList.Rows.RemoveAt(this.dgvPassengerFareList.SelectedRows[0].Index);
            }
        }

        private void txtFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtFare_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
