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
    public partial class frmSetInspectorLocation : Form
    {
        Database Cloud_Database = new Database();
        private string EmployeeID;
        private string EmployeeName;
        private string Assigned_Location;

        public string pass_employeeID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        public string pass_employeeName
        {
            get { return EmployeeName; }
            set { EmployeeName = value; }
        }

        public string pass_Assigned_Location
        {
            get { return Assigned_Location; }
            set { Assigned_Location = value; }
        }
        frmInspector frm_inspector;
        public frmSetInspectorLocation(frmInspector frm)
        {
            InitializeComponent();
            frm_inspector = frm;
        }

        private void frmSetInspectorLocation_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            txtID.Text = EmployeeID;
            txtName.Text = EmployeeName;
            txtLocation.Text = Assigned_Location;
        }

        private async void btnAssign_Click(object sender, EventArgs e)
        {
            Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Account_Data/Inspector/{txtID.Text}"));
            if (Cloud_Database.response.Body.ToString() != "null")
            {
                Accounts_Data emp_data = await Task.Run(() => Cloud_Database.response.ResultAs<Accounts_Data>());

                Accounts_Data update_acc_data = new Accounts_Data()
                {
                    id = emp_data.id,
                    firstname = emp_data.firstname,
                    surname = emp_data.surname,
                    mi = emp_data.mi,
                    contact_num = emp_data.contact_num,
                    assigned_to = txtLocation.Text,
                    position = emp_data.position,
                    password = emp_data.password
                };
                Cloud_Database.response = await Cloud_Database.client.UpdateAsync($"Account_Data/Inspector/{txtID.Text}", update_acc_data);
                await frm_inspector.LoadData();
            }
        }
    }
}
