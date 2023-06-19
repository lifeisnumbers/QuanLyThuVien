using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class NhapDauSachMoi : Form
    {
        public NhapDauSachMoi()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            txbTenDauSach.Text = string.Empty;
            cmbTenTacGia.SelectedIndex = -1;
        }

        private void btncanel1_Click(object sender, EventArgs e)
        {
            txbTenDauSach.Text += string.Empty;
            cmbNhaXuatBan.SelectedIndex = -1;
            txbNamXuatBan.Text += string.Empty;
            soluong.Value = 0;
            txbTriGia.Text = string.Empty;
        }

        private void btnNhapDauSach_Click(object sender, EventArgs e)
        {   //xét điều kiện đúng mớ hiện form dưới
            panel1.Visible = true;
        }
    }
}
