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
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btnQDdocgia_Click(object sender, EventArgs e)
        {

            btnThayDoiQuyDinh1.Visible = true;
            btnThayDoiQuyDinh2.Visible = false;
            btnThayDoiQuyDinh3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;


        }

        private void btnQDnhapsach_Click(object sender, EventArgs e)
        {

            btnThayDoiQuyDinh1.Visible = false;
            btnThayDoiQuyDinh2.Visible = false;
            btnThayDoiQuyDinh3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void btnMuonTraSach_Click(object sender, EventArgs e)
        {

            btnThayDoiQuyDinh1.Visible = false;
            btnThayDoiQuyDinh2.Visible = true;
            btnThayDoiQuyDinh3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void btnThayDoiQuyDinh3_Click(object sender, EventArgs e)
        {

        }

        private void btnThayDoiQuyDinh2_Click(object sender, EventArgs e)
        {

        }

        private void ThayDoiQuyDinh_FormClosing(object sender, FormClosingEventArgs e)
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

        private void numMaxTuoi_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numMaxTuoi.Value.ToString(), out int tuoiToiDa))
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET TuoiToiDa = @TuoiToiDa", connection))
                    {
                        command.Parameters.AddWithValue("@TuoiToiDa", tuoiToiDa);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("TuoiToiDa value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating TuoiToiDa value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid TuoiToiDa value. Please enter a valid integer number.");
            }
        }

        private void numMinTuoi_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numMinTuoi.Value.ToString(), out int TuoiToiThieu))
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET TuoiToiThieu = @TuoiToiThieu", connection))
                    {
                        command.Parameters.AddWithValue("@TuoiToiThieu", TuoiToiThieu);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("TuoiToiThieu value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating TuoiToiThieu value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid TuoiToiThieu value. Please enter a valid integer number.");
            }
        }

        private void numHetHan_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numHetHan.Value.ToString(), out int ThoiHanSuDung))
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET ThoiHanSuDung = @ThoiHanSuDung", connection))
                    {
                        command.Parameters.AddWithValue("@ThoiHanSuDung", ThoiHanSuDung);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("ThoiHanSuDung value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating ThoiHanSuDung value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ThoiHanSuDung value. Please enter a valid integer number.");
            }
        }

        private void numberKhoangCachXB_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberKhoangCachXB.Value.ToString(), out int KhaongCachXB))
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET KhaongCachXB = @KhaongCachXB", connection))
                    {
                        command.Parameters.AddWithValue("@KhaongCachXB", KhaongCachXB);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("KhaongCachXB value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating KhaongCachXB value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid KhaongCachXB value. Please enter a valid integer number.");
            }
        }

        private void numberMaxSoSach_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberMaxSoSach.Value.ToString(), out int SoNgayMuonToiDa))
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET SoSachMuonToiDa = @SoSachMuonToiDa", connection))
                    {
                        command.Parameters.AddWithValue("@SoSachMuonToiDa ", SoNgayMuonToiDa);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("SoSachMuonToiDa value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating SoSachMuonToiDa value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid SoSachMuonToiDa value. Please enter a valid integer number.");
            }
        }

        private void numberNgayMax_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberNgayMax.Value.ToString(), out int SoNgayMuonToiDa))
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET SoNgayMuonToiDa = @SoNgayMuonToiDa", connection))
                    {
                        command.Parameters.AddWithValue("@SoNgayMuonToiDa ", SoNgayMuonToiDa);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("SoNgayMuonToiDa value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating SoNgayMuonToiDa value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid SoNgayMuonToiDa value. Please enter a valid integer number.");
            }
        }

        private void numberMaxSachNgay_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberMaxSachNgay.Value.ToString(), out int KhoangCachMuonSach))
            {

                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET KhoangCachMuonSach  = @KhoangCachMuonSach ", connection))
                    {
                        command.Parameters.AddWithValue("@KhoangCachMuonSach  ", KhoangCachMuonSach);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("KhoangCachMuonSach  value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating KhoangCachMuonSach  value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid KhoangCachMuonSach  value. Please enter a valid integer number.");
            }
        }

        private void numberTienPhat_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberTienPhat.Value.ToString(), out int TienPhatTraTre))
            {

                using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE ThamSo SET TienPhatTraTre  = @TienPhatTraTre ", connection))
                    {
                        command.Parameters.AddWithValue("@TienPhatTraTre  ", TienPhatTraTre);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("TienPhatTraTre  value updated successfully.");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error updating TienPhatTraTre  value: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid TienPhatTraTre  value. Please enter a valid integer number.");
            }
        }
    }
}
