using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    public partial class frmUpdateBusses : Form
    {

        private string bus_number;
        private string bus_sits;
        private string bus_route;
        private string bus_fare;
        private string driver_id_1;
        private string driver_name_1;
        private string driver_id_2;
        private string driver_name_2;
        private string conductor_id;
        private string conductor_name;
        private string start_time;
        public string pass_start_time
        {
            get { return start_time; }
            set { start_time = value; }
        }
        public string pass_bus_number
        {
            get { return bus_number; }
            set { bus_number = value; }
        }

        public string pass_bus_sits
        {
            get { return bus_sits; }
            set { bus_sits = value; }
        }

        public string pass_bus_route
        {
            get { return bus_route; }
            set { bus_route = value; }
        }
        public string pass_bus_fare
        {
            get { return bus_fare; }
            set { bus_fare = value; }
        }
        public string pass_driver_id_1
        {
            get { return driver_id_1; }
            set { driver_id_1 = value; }
        }

        public string pass_driver_name_1
        {
            get { return driver_name_1; }
            set { driver_name_1 = value; }
        }

        public string pass_driver_id_2
        {
            get { return driver_id_2; }
            set { driver_id_2 = value; }
        }

        public string pass_driver_name_2
        {
            get { return driver_name_2; }
            set { driver_name_2 = value; }
        }

        public string pass_conductor_name
        {
            get { return conductor_name; }
            set { conductor_name = value; }
        }

        public string pass_conductor_id
        {
            get { return conductor_id; }
            set { conductor_id = value; }
        }

        Database Cloud_Database = new Database();

        frmBusses frm_busses;

        public frmUpdateBusses(frmBusses frm)
        {
            InitializeComponent();
            frm_busses = frm;
        }
        public async Task LoadPassengerFareList()
        {
            dgvPassengerFareList.Rows.Clear();
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{bus_number}/PassengerFareList/"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Dictionary<string, Bus_Data> getData = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Bus_Data>>());
                foreach (var get in getData)
                {
                    dgvPassengerFareList.Rows.Add(
                        get.Value.bus_stop,
                        get.Value.bus_fare
                        );
                }
            }
        }
        public async Task LoadEmpData()
        {
            string position = cbmPosition.Text;
            dgvChoices.Rows.Clear();
            try
            {
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/{position}"));
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

        public async Task Clear_Employee_AssignedTo(string BusNumber, string Employee_ID, string Data_Path)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{BusNumber}"));
            Bus_Data rtrv_bus_data = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

            Bus_Data bus_data_CLEAR_DRIVER_1 = new Bus_Data()
            {
                bus_number = rtrv_bus_data.bus_number,
                bus_seats = rtrv_bus_data.bus_seats,
                bus_route = rtrv_bus_data.bus_route,
                bus_fare = rtrv_bus_data.bus_fare,
                bus_driver_id_1 = "",
                bus_driver_name_1 = "N/A",
                bus_driver_id_2 = rtrv_bus_data.bus_driver_id_2,
                bus_driver_name_2 = rtrv_bus_data.bus_driver_name_2,
                bus_conductor_id = rtrv_bus_data.bus_conductor_id,
                bus_conductor_name = rtrv_bus_data.bus_conductor_name
            };

            Bus_Data bus_data_CLEAR_DRIVER_2 = new Bus_Data()
            {
                bus_number = rtrv_bus_data.bus_number,
                bus_seats = rtrv_bus_data.bus_seats,
                bus_route = rtrv_bus_data.bus_route,
                bus_fare = rtrv_bus_data.bus_fare,
                bus_driver_id_1 = rtrv_bus_data.bus_driver_id_1,
                bus_driver_name_1 = rtrv_bus_data.bus_driver_name_1,
                bus_driver_id_2 = "",
                bus_driver_name_2 = "N/A/",
                bus_conductor_id = rtrv_bus_data.bus_conductor_id,
                bus_conductor_name = rtrv_bus_data.bus_conductor_name
            };

            Bus_Data bus_data_CLEAR_CONDUCTOR = new Bus_Data()
            {
                bus_number = rtrv_bus_data.bus_number,
                bus_seats = rtrv_bus_data.bus_seats,
                bus_route = rtrv_bus_data.bus_route,
                bus_fare = rtrv_bus_data.bus_fare,
                bus_driver_id_1 = rtrv_bus_data.bus_driver_id_1,
                bus_driver_name_1 = rtrv_bus_data.bus_driver_name_1,
                bus_driver_id_2 = rtrv_bus_data.bus_driver_id_2,
                bus_driver_name_2 = rtrv_bus_data.bus_driver_name_2,
                bus_conductor_id = "",
                bus_conductor_name = "N/A"
            };

            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync(Data_Path));
            Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

            Accounts_Data Account_Data = new Accounts_Data()
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

            Cloud_Database.response = await Cloud_Database.client.UpdateAsync(Data_Path, Account_Data);

            if (Employee_ID.Equals(rtrv_bus_data.bus_driver_id_1))
            {
                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{BusNumber}", bus_data_CLEAR_DRIVER_1);
            }

            if (Employee_ID.Equals(rtrv_bus_data.bus_driver_id_2))
            {
                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{BusNumber}", bus_data_CLEAR_DRIVER_2);
            }

            if (Employee_ID.Equals(rtrv_bus_data.bus_conductor_id)) 
            {
                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{BusNumber}", bus_data_CLEAR_CONDUCTOR);
            }
        }

        private async Task Update_Employee_AssignedTo(string Data_Path) 
        {
            //Search Driver ID
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync(Data_Path));
            Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

            //Update Driver Account Data
            Accounts_Data Account_Data = new Accounts_Data()
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
            Cloud_Database.response = await Cloud_Database.client.UpdateAsync(Data_Path, Account_Data);
        }

        private async Task Update_Employee_AssignedTo(string BusNumber, string Employee_ID, string Bus_Employee_ID, string Data_Path)
        {
            if (string.IsNullOrWhiteSpace(BusNumber))
            {
                MessageBox.Show("Buss number cannot be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Employee_ID != Bus_Employee_ID)
                {
                    if (string.IsNullOrWhiteSpace(Bus_Employee_ID))
                    {
                        await Update_Employee_AssignedTo(Data_Path);
                    }
                    else
                    {
                        await Clear_Employee_AssignedTo(BusNumber, Employee_ID, Data_Path);
                        await Update_Employee_AssignedTo(Data_Path);
                    }
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{txtBusNumber.Text}"));
            Bus_Data BusData = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

            await Update_Employee_AssignedTo(txtBusNumber.Text, txtDriverID_1.Text, BusData.bus_driver_id_1, $"Account_Data/Driver/{txtDriverID_1.Text}");
            await Update_Employee_AssignedTo(txtBusNumber.Text, txtDriverID_2.Text, BusData.bus_driver_id_2, $"Account_Data/Driver/{txtDriverID_2.Text}");
            await Update_Employee_AssignedTo(txtBusNumber.Text, txtConductorID.Text, BusData.bus_conductor_id, $"Account_Data/Conductor/{txtConductorID.Text}");
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
            Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Bus_Data/Busses/{txtBusNumber.Text}", bus_data);
            await LoadEmpData();
            await frm_busses.LoadBusData();
        }

        private async void btnClearDriver_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{txtBusNumber.Text}"));
            Bus_Data rtrv_bus_data = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

            if (string.IsNullOrWhiteSpace(rtrv_bus_data.bus_driver_id_1))
            {
                txtDriverID_1.Clear();
                txtDriverName_1.Clear();
                btnClearDriver.Enabled = false;
            }
            else
            {
                await Clear_Employee_AssignedTo(txtBusNumber.Text, txtDriverID_1.Text, $"Account_Data/Driver/{rtrv_bus_data.bus_driver_id_1}");
                txtDriverID_1.Clear();
                txtDriverName_1.Clear();
                await LoadEmpData();
                await frm_busses.LoadBusData();
                btnClearDriver.Enabled = false;
            }
        }

        private async void btnClearDriver2_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{txtBusNumber.Text}"));
            Bus_Data rtrv_bus_data = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

            if (string.IsNullOrWhiteSpace(rtrv_bus_data.bus_driver_id_2))
            {
                txtDriverID_2.Clear();
                txtDriverName_2.Clear();
                btnClearDriver2.Enabled = false;
            }
            else
            {
                await Clear_Employee_AssignedTo(txtBusNumber.Text, txtDriverID_2.Text, $"Account_Data/Driver/{rtrv_bus_data.bus_driver_id_2}");
                txtDriverID_2.Clear();
                txtDriverName_2.Clear();
                await LoadEmpData();
                await frm_busses.LoadBusData();
                btnClearDriver2.Enabled = false;
            }
        }

        private async void btnClearConductor_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Bus_Data/Busses/{txtBusNumber.Text}"));
            Bus_Data rtrv_bus_data = await Task.Run(() => Cloud_Database.response.ResultAs<Bus_Data>());

            if (string.IsNullOrWhiteSpace(rtrv_bus_data.bus_conductor_id))
            {
                txtConductorID.Clear();
                txtConductorName.Clear();
                btnClearConductor.Enabled = false;
            }
            else
            {
                await Clear_Employee_AssignedTo(txtBusNumber.Text, txtConductorID.Text, $"Account_Data/Conductor/{rtrv_bus_data.bus_conductor_id}");
                txtConductorID.Clear();
                txtConductorName.Clear();
                await LoadEmpData();
                await frm_busses.LoadBusData();
                btnClearConductor.Enabled = false;
            }
        }

        private void frmUpdateBusses_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            _ = LoadPassengerFareList();
            cbmPosition.SelectedIndex = 0;
            txtBusNumber.Text = bus_number;
            txtBusSits.Text = bus_sits;
            txtBusRoute.Text = bus_route;
            txtDriverID_1.Text = driver_id_1;
            txtDriverName_1.Text = driver_name_1;
            txtDriverID_2.Text = driver_id_2;
            txtDriverName_2.Text = driver_name_2;
            txtConductorID.Text = conductor_id;
            txtConductorName.Text = conductor_name;
            dtpScheduleFrom.Value = DateTime.ParseExact(start_time, "h:mm tt", CultureInfo.InvariantCulture);
        }

        private async void cbmPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadEmpData();
        }

        private void dgvChoices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedrowindex = dgvChoices.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvChoices.Rows[selectedrowindex];

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

        private void txtDriverID_1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDriverID_1.Text))
            {
                btnClearDriver.Enabled = false;
            }
            else 
            {
                btnClearDriver.Enabled = true;
            }
        }

        private void txtDriverID_2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDriverID_2.Text))
            {
                btnClearDriver2.Enabled = false;
            }
            else
            {
                btnClearDriver2.Enabled = true;
            }
        }

        private void txtConductorID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConductorID.Text))
            {
                btnClearConductor.Enabled = false;
            }
            else 
            {
                btnClearConductor.Enabled = true;
            }
        }

        private void dgvPassengerFareList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedrowindex = dgvPassengerFareList.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvPassengerFareList.Rows[selectedrowindex];
            if (dgvPassengerFareList.SelectedCells.Count > 0)
            {
                txtArea.Text = row.Cells[0].Value.ToString();
                txtFare.Text = row.Cells[1].Value.ToString();
            }
        }

        private async void btnUpdateRoute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArea.Text) || !string.IsNullOrWhiteSpace(txtArea.Text) ||
                !string.IsNullOrEmpty(txtFare.Text) || !string.IsNullOrWhiteSpace(txtFare.Text))
            {
                Bus_Data PassengerFareList = new Bus_Data
                {
                    bus_stop = txtArea.Text,
                    bus_fare = txtFare.Text
                };
                Cloud_Database.response = await Cloud_Database.client.SetAsync($"Bus_Data/Busses/{txtBusNumber.Text}/PassengerFareList/{txtArea.Text}", PassengerFareList);
                LoadPassengerFareList();
                txtArea.Clear();
                txtFare.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArea.Text) || !string.IsNullOrWhiteSpace(txtArea.Text))
            {
                Cloud_Database.response = Cloud_Database.client.Delete($"Bus_Data/Busses/{txtBusNumber.Text}/PassengerFareList/{txtArea.Text}");
                LoadPassengerFareList();
                txtArea.Clear();
                txtFare.Clear();
            }
        }

        private void txtFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
