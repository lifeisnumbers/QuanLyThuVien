namespace QuanLyThuVien
{
    partial class SubFormMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTacGia = new Label();
            lbTheLoai = new Label();
            lbTenSach = new Label();
            lbMaSach = new Label();
            lbNgayMuon = new Label();
            lbDocGia = new Label();
            lbPMS = new Label();
            SuspendLayout();
            // 
            // lbTacGia
            // 
            lbTacGia.AutoSize = true;
            lbTacGia.Location = new Point(144, 359);
            lbTacGia.Name = "lbTacGia";
            lbTacGia.Size = new Size(65, 25);
            lbTacGia.TabIndex = 14;
            lbTacGia.Text = "Tác giả";
            // 
            // lbTheLoai
            // 
            lbTheLoai.AutoSize = true;
            lbTheLoai.Location = new Point(136, 307);
            lbTheLoai.Name = "lbTheLoai";
            lbTheLoai.Size = new Size(73, 25);
            lbTheLoai.TabIndex = 13;
            lbTheLoai.Text = "Thể loại";
            // 
            // lbTenSach
            // 
            lbTenSach.AutoSize = true;
            lbTenSach.Location = new Point(144, 262);
            lbTenSach.Name = "lbTenSach";
            lbTenSach.Size = new Size(78, 25);
            lbTenSach.TabIndex = 12;
            lbTenSach.Text = "Tên sách";
            // 
            // lbMaSach
            // 
            lbMaSach.AutoEllipsis = true;
            lbMaSach.AutoSize = true;
            lbMaSach.Location = new Point(153, 221);
            lbMaSach.Name = "lbMaSach";
            lbMaSach.Size = new Size(77, 25);
            lbMaSach.TabIndex = 11;
            lbMaSach.Text = "Mã sách";
            // 
            // lbNgayMuon
            // 
            lbNgayMuon.AutoSize = true;
            lbNgayMuon.Location = new Point(426, 139);
            lbNgayMuon.Name = "lbNgayMuon";
            lbNgayMuon.Size = new Size(107, 25);
            lbNgayMuon.TabIndex = 10;
            lbNgayMuon.Text = "Ngày mượn";
            // 
            // lbDocGia
            // 
            lbDocGia.AutoSize = true;
            lbDocGia.Location = new Point(117, 139);
            lbDocGia.Name = "lbDocGia";
            lbDocGia.Size = new Size(102, 25);
            lbDocGia.TabIndex = 9;
            lbDocGia.Text = "Tên đọc giả";
            // 
            // lbPMS
            // 
            lbPMS.AutoSize = true;
            lbPMS.Location = new Point(268, 53);
            lbPMS.Name = "lbPMS";
            lbPMS.Size = new Size(148, 25);
            lbPMS.TabIndex = 8;
            lbPMS.Text = "Phiếu mượn sách";
            // 
            // SubFormMuonSach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTacGia);
            Controls.Add(lbTheLoai);
            Controls.Add(lbTenSach);
            Controls.Add(lbMaSach);
            Controls.Add(lbNgayMuon);
            Controls.Add(lbDocGia);
            Controls.Add(lbPMS);
            Name = "SubFormMuonSach";
            Text = "SubFormMuonSach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbTacGia;
        private Label lbTheLoai;
        private Label lbTenSach;
        private Label lbMaSach;
        private Label lbNgayMuon;
        private Label lbDocGia;
        private Label lbPMS;
    }
}