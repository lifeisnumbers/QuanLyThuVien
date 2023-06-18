using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class HomeTable : Form
    {
        public HomeTable()
        {
            InitializeComponent();
        }

        private void thêmĐầuSáchMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lậpĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemDocGia themDocGiaCon = new ThemDocGia();
            themDocGiaCon.ShowDialog();

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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh thayDoiQuyDinh = new ThayDoiQuyDinh();
            thayDoiQuyDinh.ShowDialog();
        }
    }
}