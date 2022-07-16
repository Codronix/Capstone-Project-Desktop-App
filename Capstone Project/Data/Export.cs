using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project.Data
{
    class Export
    {
        public void ExportToExcel(DataGridView dataGrid, string File_Name) 
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = File_Name;
            sf.Filter = "Excel Documents (*.xlsx)|*.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null; 
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = File_Name;
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                } 
                workbook.SaveAs(sf.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}
