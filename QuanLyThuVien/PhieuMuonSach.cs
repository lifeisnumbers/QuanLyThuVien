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
    public partial class PhieuMuonSach : Form
    {
        string connectionString = Program.ConnectionString;

        public PhieuMuonSach()
        {
            InitializeComponent();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            int MaDocGia = int.Parse(txbMaDocGia.Text);
            int MaCuonSach = int.Parse(txbMaCuonSach.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("MuonSach", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                        command.Parameters.AddWithValue("@MaCuonSach", MaCuonSach);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Đọc giả đã mượn sách!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi: " + ex.Message);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            txbMaCuonSach.Text = string.Empty;
            txbMaDocGia.Text = string.Empty;
        }

        private void PhieuMuonSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hỏi người dùng xác nhận thoát
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    // Nếu người dùng chọn No, hủy sự kiện FormClosing
                    e.Cancel = true;
                }
            }
        }
    }
}
