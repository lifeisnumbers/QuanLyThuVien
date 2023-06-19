using ClosedXML.Excel;
using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class BaoCaoSachTraTre : Form
    {
        public BaoCaoSachTraTre()
        {
            InitializeComponent();
        }

        private void dataSachTraTre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BaoCaoSachTraTre_Load(object sender, EventArgs e)
        {
            string query = "EXEC BaoCaoTraTre";

            // Execute the stored procedure with the parameter
            DataTable result = BangBaoCaoTraTre.Instance.ExecuteQuery(query);

            DateTime now = DateTime.Now;
            string ThangNam = now.ToString();
            label2.Text = "Ngày lập báo cáo: " + ThangNam;


            // Assign the result to the data source
            dataSachTraTre.DataSource = result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "EXEC BaoCaoTraTre";

            DataTable result = BangBaoCaoTraTre.Instance.ExecuteQuery(query);

            DateTime now = DateTime.Now;
            string ThangNam = now.ToString("dd_MM_yyyy");

            // Convert the DataTable to Excel
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("BaoCaoTraTre");

                // Set the header row
                for (int i = 0; i < result.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = result.Columns[i].ColumnName;
                }

                // Set the data rows
                // Set the data rows
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    for (int j = 0; j < result.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = result.Rows[i][j].ToString();
                    }
                }

                // Set the values of ThangNam and tongLuotMuon
                worksheet.Cell(result.Rows.Count + 2, 1).Value = "Ngày Báo Cáo:";
                worksheet.Cell(result.Rows.Count + 2, 2).Value = ThangNam;

                // Save the workbook
                string filePath = "C:\\Users\\N E O\\Desktop\\ExcelTest\\bao_cao_ngay_" + ThangNam + ".xlsx";

                workbook.SaveAs(filePath);
            }

            MessageBox.Show("Báo cáo đã được xuất thành công!");
        }
    }
}
