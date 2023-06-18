﻿using QuanLyThuVien.DAO;
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
    public partial class NhapDauSachCu : Form
    {
        private nxbDAO nxb_DAO;
        private DauSachDAO dauSach_DAO;
        string connectionSTR = Program.ConnectionString;

        public NhapDauSachCu()
        {
            InitializeComponent();
            nxb_DAO = new nxbDAO(Program.ConnectionString);
            dauSach_DAO = new DauSachDAO(Program.ConnectionString);
        }

        private void LoadComboBox()
        {
            List<DauSachDTO> dausachList = dauSach_DAO.DanhSachDauSach();
            cmbDauSach.DataSource = dausachList;
            cmbDauSach.DisplayMember = "TenDauSach";
            cmbDauSach.ValueMember = "MaDauSach";


            List<nxbDTO> nxbList = nxb_DAO.GetnxbList();
            cmbNXB.DataSource = nxbList;
            cmbNXB.DisplayMember = "TenNXB";
            cmbNXB.ValueMember = "MaNXB";

        }

        private void btnCanel_Click(object sender, EventArgs e)
        {

        }

        private void NhapDauSachMoi_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            // Retrieve form inputs
            int MaDauSach = (int)cmbDauSach.SelectedValue;
            string TenSach = txbSach.Text;
            string TriGia = txbMoney.Text;
            int MaNXB = (int)cmbNXB.SelectedValue;
            int NamXuatBan = int.Parse(txbNamXuatBan.Text);
            int SoLuong = (int)numSach.Value;

            decimal giaValue;

            if (Decimal.TryParse(TriGia, out giaValue))
            {
                giaValue = Decimal.Round(giaValue, 2); // Round to 2 decimal places
                                                       // Now you can use the 'giaValue' decimal variable in your code
            }
            else
            {
                // The string 'TriGia' couldn't be parsed as a decimal
                // Handle the error accordingly
                MessageBox.Show("Invalid price value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    // Insert into DauSach table using a stored procedure
                    using (SqlCommand cmd = new SqlCommand("ThemSach", connection))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaDauSach", MaDauSach);
                        cmd.Parameters.AddWithValue("@TenSach", TenSach);
                        cmd.Parameters.AddWithValue("@TriGia", giaValue);
                        cmd.Parameters.AddWithValue("@MaNXB", MaNXB);
                        cmd.Parameters.AddWithValue("@NamXuatBan", NamXuatBan);

                        // Add an output parameter to retrieve the generated MaSach value
                        SqlParameter maSachParam = cmd.Parameters.Add("@MaSach", SqlDbType.Int);
                        maSachParam.Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        // Retrieve the generated MaSach value
                        int MaSach = (int)maSachParam.Value;

                        for (int i = 0; i < SoLuong; i++)
                        {
                            using (SqlCommand cmdCuonSach = new SqlCommand("INSERT INTO CuonSach (MaSach, TinhTrang) VALUES (@MaSach, 1)", connection))
                            {
                                cmdCuonSach.Parameters.AddWithValue("@MaSach", MaSach);
                                cmdCuonSach.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                        MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
