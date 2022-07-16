using Capstone_Project.Data;
using Capstone_Project.Forms.Payroll_Module;
using Capstone_Project.Forms.SystemSettings_Module;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmPayrollRecords : Form
    {
        Database Cloud_Database = new Database();
        public frmPayrollRecords()
        {
            InitializeComponent();
        }

        public async Task LoadData() 
        {
            try
            {
                dgvDataView.Rows.Clear();
                Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync("Payroll_Records/"));
                if (Cloud_Database.response.Body != "null")
                {
                    Dictionary<string, Payroll_Data> payroll_records = await Task.Run(() => Cloud_Database.response.ResultAs<Dictionary<string, Payroll_Data>>());
                    foreach (var get in payroll_records)
                    {
                        dgvDataView.Rows.Add(
                            get.Value.date,
                            get.Value.employee_id,
                            get.Value.employee_name,
                            get.Value.position,
                            get.Value.gross_pay,
                            get.Value.total_deduction,
                            get.Value.net_pay
                            );
                    }
                }
            }
            catch 
            {
                
            }
        }
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmPayroll frm_payroll = new frmPayroll(this);
            frm_payroll.ShowDialog(this);
        }

        private async void frmPayrollRecords_Load(object sender, EventArgs e)
        {
            Cloud_Database.Cloud_DB_Connect();
            await LoadData();
        }

        private async void btnPayslip_Click(object sender, EventArgs e)
        {
            if (dgvDataView.SelectedCells.Count > 0)
            {
                frmPayslipViewer PaySlipViewer = new frmPayslipViewer();
                Payslip payslip = new Payslip();
                int SelectedRowIndex = dgvDataView.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvDataView.Rows[SelectedRowIndex];

                TextObject Text_Date = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDate"];
                TextObject Text_EmployeeID = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtEmployeeID"];
                TextObject Text_EmployeeName = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtEmployeeName"];
                TextObject Text_HourlyRate = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtHourlyRate"];
                TextObject Text_TotalHoursWork = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtTotalHoursWork"];
                TextObject Text_GrossPay = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtGrossPay"];
                TextObject Text_DeductionText1 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionText1"];
                TextObject Text_DeductionText2 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionText2"];
                TextObject Text_DeductionText3 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionText3"];
                TextObject Text_DeductionText4 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionText4"];
                TextObject Text_DeductionAmount1 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionAmount1"];
                TextObject Text_DeductionAmount2 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionAmount2"];
                TextObject Text_DeductionAmount3 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionAmount3"];
                TextObject Text_DeductionAmount4 = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtDeductionAmount4"];
                TextObject Text_TotalDeductions = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtTotalDeductions"];
                TextObject Text_NetPay = (TextObject)payslip.ReportDefinition.Sections["Section3"].ReportObjects["txtNetPay"];
                List<string> Deductions = new List<string>();
                List<string> DeductionAmount = new List<string>();
                try
                {
                    if (Cloud_Database.isConnected_TO_Internet() == true)
                    {
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Payroll_Records/{row.Cells[1].Value.ToString()}"));
                        Payroll_Data payroll_Data = await Task.Run(() => Cloud_Database.response.ResultAs<Payroll_Data>());
                        Text_Date.Text = payroll_Data.date;
                        Text_EmployeeID.Text = payroll_Data.employee_id;
                        Text_EmployeeName.Text = payroll_Data.employee_name;
                        Text_HourlyRate.Text = payroll_Data.hourly_rate;
                        Text_TotalHoursWork.Text = payroll_Data.total_hours_work;
                        Text_GrossPay.Text = payroll_Data.gross_pay;
                        Text_TotalDeductions.Text = payroll_Data.total_deduction;
                        Text_NetPay.Text = payroll_Data.net_pay;
                        Cloud_Database.response = await Task.Run(() => Cloud_Database.client.GetAsync($"Payroll_Records/{row.Cells[1].Value.ToString()}/Deductions"));
                        if (Cloud_Database.response.Body.ToString() != "null")
                        {
                            Dictionary<string, Deductions_Data> getData = Cloud_Database.response.ResultAs<Dictionary<string, Deductions_Data>>();
                            foreach (var deductions in getData)
                            {
                                Deductions.Add(deductions.Value.DeductionType);
                                DeductionAmount.Add(deductions.Value.MonthlyDeduction);
                            }
                            try
                            {
                                Text_DeductionText1.Text = Deductions[0];
                                Text_DeductionAmount1.Text = DeductionAmount[0];

                                Text_DeductionText2.Text = Deductions[1];
                                Text_DeductionAmount2.Text = DeductionAmount[1];

                                Text_DeductionText3.Text = Deductions[2];
                                Text_DeductionAmount3.Text = DeductionAmount[2];

                                Text_DeductionText4.Text = Deductions[3];
                                Text_DeductionAmount4.Text = DeductionAmount[3];
                            }
                            catch { }
                        }
                        
                        PaySlipViewer.crystalReportViewer1.ReportSource = payslip;
                        PaySlipViewer.Show();
                    }
                    else
                    {
                        MessageBox.Show("Internet not available.", "Check Internet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show("There is a problem processing the task. Please Try Again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnExport_Excel_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.ExportToExcel(dgvDataView, "Payroll Records");
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            frmDeductions Employee_Deduction_FORM = new frmDeductions();
            Employee_Deduction_FORM.ShowDialog();
        }

        private void btnIncentives_Click(object sender, EventArgs e)
        {
            frmQuotaSettings frmQuotaSettings = new frmQuotaSettings();
            frmQuotaSettings.ShowDialog();
        }
    }
}
