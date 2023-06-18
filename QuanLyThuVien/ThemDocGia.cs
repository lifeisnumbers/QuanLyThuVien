using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
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
    public partial class ThemDocGia : Form
    {
        private LoaiDocGiaDAO loaiDocGiaDAO;
        public ThemDocGia()
        {
            InitializeComponent();
            loaiDocGiaDAO = new LoaiDocGiaDAO(Program.ConnectionString);
        }
        private void ThemDocGia_Load(object sender, EventArgs e)
        {
            Load_LoaiDocGia();
        }

        private void Load_LoaiDocGia()
        {
            List<LoaiDocGiaDTO> loaidocgia = loaiDocGiaDAO.DanhSachLoaiDocGia();
            cmbLoaiDocGia.DataSource = loaidocgia;
            cmbLoaiDocGia.DisplayMember = "LoaiDocGia";
            cmbLoaiDocGia.ValueMember = "MaLoaiDocGia";

        }

        private void btnTaoDocGia_Click(object sender, EventArgs e)
        {
            if (txBHovaTen.Text != "" && cmbLoaiDocGia.Text != "" && txBDiaChi.Text != "" && txBEmail.Text != "")
            {
                string HoTen = txBHovaTen.Text;
                int LoaiDocGia = (int)cmbLoaiDocGia.SelectedValue;
                string DiaChi = txBDiaChi.Text;
                string Email = txBEmail.Text;
                DateTime NgaySinh = dateNgaySinh.Value.Date;
                int SachQuaHan = 0;
                decimal TongNo = 0;

                // Establish a connection to your database
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a command object to execute the stored procedure
                        using (SqlCommand command = new SqlCommand("ThemDocGia", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Provide the parameter values for the stored procedure
                            command.Parameters.AddWithValue("@HoTen", HoTen);
                            command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                            command.Parameters.AddWithValue("@DiaChi", DiaChi);
                            command.Parameters.AddWithValue("@Email", Email);
                            command.Parameters.AddWithValue("@MaLoaiDocGia", LoaiDocGia);

                            // Execute the stored procedure
                            command.ExecuteNonQuery();
                            MessageBox.Show("Thêm đọc giả thành công.");

                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that occur during the database operation
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                // Display an error message for missing input
                MessageBox.Show("Vui lòng xác nhận lại thông tin độc giả.");
            }
        }

        private void txBHovaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
