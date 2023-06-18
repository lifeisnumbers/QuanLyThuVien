﻿using System;
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
    public partial class PhieuThu : Form
    {
        public PhieuThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Program.ConnectionString;

            int MaDocGia = int.Parse(txbMaDocGia.Text);
            string SoTien = txbMaCuonSach.Text;
            decimal sotienValue;

            if (Decimal.TryParse(SoTien, out sotienValue))
            {
                sotienValue = Decimal.Round(sotienValue, 2); // Round to 2 decimal places
                                                             // Now you can use the 'giaValue' decimal variable in your code
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ThuTien", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                        command.Parameters.AddWithValue("@SoTien", sotienValue);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Đã thu tiền.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phát sinh lỗi: " + ex.Message);
            }
        }
    }
}
