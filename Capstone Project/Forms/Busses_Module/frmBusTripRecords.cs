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
    public partial class frmBusTripRecords : Form
    {
        Database Cloud_Databases = new Database();
        public frmBusTripRecords()
        {
            InitializeComponent();
        }

        public async Task LoadData(string dateID) 
        {
            dgvDataView.Rows.Clear();
            try
            {
                Cloud_Databases.response = await Task.Run(() => Cloud_Databases.client.GetAsync($"BusTripRecords_Data/{dateID}"));
                Dictionary<string, BusTripRecords_Data> get_BusTrip_Data = await Task.Run(() => Cloud_Databases.response.ResultAs<Dictionary<string, BusTripRecords_Data>>());
                foreach (var get in get_BusTrip_Data)
                {
                    Cloud_Databases.response = await Task.Run(() => Cloud_Databases.client.GetAsync($"BusTripRecords_Data/{dateID}/{get.Value.Travel_ID}"));
                    var TotalProfit = Cloud_Databases.response.ResultAs<BusTripRecords_Data>();
                    double profit = double.Parse(TotalProfit.Total_Profit);
                    dgvDataView.Rows.Add(
                        get.Value.Date_Of_Trip,
                        get.Value.Travel_ID,
                        get.Value.Bus_Number,
                        get.Value.Bus_Route,
                        profit.ToString("0,0.00")
                        );
                }
                dgvDataView.ClearSelection();
            }catch{}
        }
        private async void frmBusTripRecords_Load(object sender, EventArgs e)
        {
            string dateNow = dateTimePicker1.Text;
            string dateID = dateNow.Replace("/", string.Empty);
            Cloud_Databases.Cloud_DB_Connect();
            await LoadData(dateID);
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            string date_string_id = date.Replace("/", "");
            await LoadData(date_string_id);
        }

        private void btnExport_Excel_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.ExportToExcel(dgvDataView, "Bus Trip Records");
        }
    }
}
