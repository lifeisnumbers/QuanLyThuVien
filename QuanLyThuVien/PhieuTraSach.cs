using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class PhieuTraSach : Form
    {
        public PhieuTraSach()
        {
            InitializeComponent();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            string connectionString = Program.ConnectionString;

            int MaDocGia = int.Parse(txbMaDocGia.Text);
            int MaCuonSach = int.Parse(txbMaCuonSach.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("TraSach", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                        command.Parameters.AddWithValue("@MaCuonSach", MaCuonSach);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Sách đã được trả về thư viện.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
