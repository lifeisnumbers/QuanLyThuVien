namespace QuanLyThuVien
{
    public partial class HomeTable : Form
    {
        public HomeTable()
        {
            InitializeComponent();
        }

        private void lậpĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemDocGia themDocGia = new ThemDocGia();
            themDocGia.ShowDialog();
        }
        private void thêmĐầuSáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapDauSachMoi nhapDauSachMoi = new NhapDauSachMoi();
            nhapDauSachMoi.ShowDialog();
        }

        private void thêmĐầuSáchCũToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhapDauSachCu nhapDauSachCu = new NhapDauSachCu();
            nhapDauSachCu.ShowDialog();
        }

        private void traCứuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuSach traCuuSach = new TraCuuSach();
            traCuuSach.ShowDialog();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonSach phieuMuonSach = new PhieuMuonSach();
            phieuMuonSach.ShowDialog();

        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTraSach phieuTraSach = new PhieuTraSach();
            phieuTraSach.ShowDialog();
        }

        private void mượnSáchTheoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoThangTheLoai baoCaoThangTheLoai = new BaoCaoThangTheLoai();
            baoCaoThangTheLoai.ShowDialog();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh thayDoiQuyDinh = new ThayDoiQuyDinh();
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
            BaoCaoSachTraTre baoCaoSachTraTre = new BaoCaoSachTraTre();
            baoCaoSachTraTre.ShowDialog();
        }
    }
}