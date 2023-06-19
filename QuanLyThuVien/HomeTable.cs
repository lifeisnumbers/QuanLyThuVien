﻿namespace QuanLyThuVien
{   
    public partial class HomeTable : Form
    {
        
        public HomeTable()
        {
            InitializeComponent();
    
        }

        private void lậpĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ThemDocGia themDocGia = new ThemDocGia(this);
            themDocGia.ShowDialog();

        }
        private void thêmĐầuSáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {   Hide();
            NhapDauSachMoi nhapDauSachMoi = new NhapDauSachMoi(this);
            nhapDauSachMoi.ShowDialog();
        }

        private void thêmĐầuSáchCũToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            NhapDauSachCu nhapDauSachCu = new NhapDauSachCu(this);
            nhapDauSachCu.ShowDialog();
        }

        private void traCứuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TraCuuSach traCuuSach = new TraCuuSach(this);
            traCuuSach.ShowDialog();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            PhieuMuonSach phieuMuonSach = new PhieuMuonSach(this);
            phieuMuonSach.ShowDialog();

        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            PhieuTraSach phieuTraSach = new PhieuTraSach(this);
            phieuTraSach.ShowDialog();
        }

        private void mượnSáchTheoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {   Hide();
            BaoCaoThangTheLoai baoCaoThangTheLoai = new BaoCaoThangTheLoai(this);
            baoCaoThangTheLoai.ShowDialog();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ThayDoiQuyDinh thayDoiQuyDinh = new ThayDoiQuyDinh(this);
            thayDoiQuyDinh.ShowDialog();
        }

        private void HomeTable_FormClosing(object sender, FormClosingEventArgs e)
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

        private void thốngKêSáchTrảTrễToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BaoCaoSachTraTre baoCaoSachTraTre = new BaoCaoSachTraTre(this);
            baoCaoSachTraTre.ShowDialog();
        }

        private void HomeTable_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}