namespace QuanLyThuVien
{
    partial class SubFormTraSach
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
            lbSoNgayMuon = new Label();
            lbTienPhat = new Label();
            lbMaSach = new Label();
            lbNgayMuon = new Label();
            lbDocGia = new Label();
            lbPMS = new Label();
            lbNgayTra = new Label();
            lbTongNo = new Label();
            SuspendLayout();
            // 
            // lbSoNgayMuon
            // 
            lbSoNgayMuon.AutoSize = true;
            lbSoNgayMuon.Location = new Point(162, 336);
            lbSoNgayMuon.Name = "lbSoNgayMuon";
            lbSoNgayMuon.Size = new Size(130, 25);
            lbSoNgayMuon.TabIndex = 21;
            lbSoNgayMuon.Text = "Số ngày mượn";
            // 
            // lbTienPhat
            // 
            lbTienPhat.AutoSize = true;
            lbTienPhat.Location = new Point(212, 374);
            lbTienPhat.Name = "lbTienPhat";
            lbTienPhat.Size = new Size(85, 25);
            lbTienPhat.TabIndex = 20;
            lbTienPhat.Text = "Tiền phạt";
            // 
            // lbMaSach
            // 
            lbMaSach.AutoEllipsis = true;
            lbMaSach.AutoSize = true;
            lbMaSach.Location = new Point(215, 243);
            lbMaSach.Name = "lbMaSach";
            lbMaSach.Size = new Size(77, 25);
            lbMaSach.TabIndex = 18;
            lbMaSach.Text = "Mã sách";
            // 
            // lbNgayMuon
            // 
            lbNgayMuon.AutoSize = true;
            lbNgayMuon.Location = new Point(190, 286);
            lbNgayMuon.Name = "lbNgayMuon";
            lbNgayMuon.Size = new Size(107, 25);
            lbNgayMuon.TabIndex = 17;
            lbNgayMuon.Text = "Ngày mượn";
            // 
            // lbDocGia
            // 
            lbDocGia.AutoSize = true;
            lbDocGia.Location = new Point(190, 149);
            lbDocGia.Name = "lbDocGia";
            lbDocGia.Size = new Size(102, 25);
            lbDocGia.TabIndex = 16;
            lbDocGia.Text = "Tên đọc giả";
            // 
            // lbPMS
            // 
            lbPMS.AutoSize = true;
            lbPMS.Location = new Point(341, 63);
            lbPMS.Name = "lbPMS";
            lbPMS.Size = new Size(148, 25);
            lbPMS.TabIndex = 15;
            lbPMS.Text = "Phiếu mượn sách";
            // 
            // lbNgayTra
            // 
            lbNgayTra.AutoSize = true;
            lbNgayTra.Location = new Point(527, 128);
            lbNgayTra.Name = "lbNgayTra";
            lbNgayTra.Size = new Size(81, 25);
            lbNgayTra.TabIndex = 22;
            lbNgayTra.Text = "Ngày Trả";
            // 
            // lbTongNo
            // 
            lbTongNo.AutoSize = true;
            lbTongNo.Location = new Point(536, 173);
            lbTongNo.Name = "lbTongNo";
            lbTongNo.Size = new Size(79, 25);
            lbTongNo.TabIndex = 23;
            lbTongNo.Text = "Tổng nợ";
            // 
            // SubFormTraSach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTongNo);
            Controls.Add(lbNgayTra);
            Controls.Add(lbSoNgayMuon);
            Controls.Add(lbTienPhat);
            Controls.Add(lbMaSach);
            Controls.Add(lbNgayMuon);
            Controls.Add(lbDocGia);
            Controls.Add(lbPMS);
            Name = "SubFormTraSach";
            Text = "SubFormTraSach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSoNgayMuon;
        private Label lbTienPhat;
        private Label lbMaSach;
        private Label lbNgayMuon;
        private Label lbDocGia;
        private Label lbPMS;
        private Label lbNgayTra;
        private Label lbTongNo;
    }
}