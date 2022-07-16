using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project.Data
{
    class Export_Excel
    {
        public void Export(DataGridView dataGrid, string File_Name) 
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = File_Name;
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
                worksheet.Name = File_Name;

                // storing header part in Excel  
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(sf.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
        }
    }
}
