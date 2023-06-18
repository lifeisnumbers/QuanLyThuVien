namespace QuanLyThuVien
{
    partial class PhieuMuonSach
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbMaDocGia = new TextBox();
            txbMaCuonSach = new TextBox();
            btnMuonSach = new Button();
            btnCanel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 26);
            label1.Name = "label1";
            label1.Size = new Size(353, 46);
            label1.TabIndex = 0;
            label1.Text = "Phiếu mượn sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(162, 90);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 1;
            label2.Text = "Mã độc giả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 140);
            label3.Name = "label3";
            label3.Size = new Size(180, 29);
            label3.TabIndex = 2;
            label3.Text = "Mã cuốn sách:";
            // 
            // txbMaDocGia
            // 
            txbMaDocGia.Location = new Point(358, 90);
            txbMaDocGia.Name = "txbMaDocGia";
            txbMaDocGia.Size = new Size(185, 28);
            txbMaDocGia.TabIndex = 1;
            // 
            // txbMaCuonSach
            // 
            txbMaCuonSach.Location = new Point(358, 140);
            txbMaCuonSach.Name = "txbMaCuonSach";
            txbMaCuonSach.Size = new Size(185, 28);
            txbMaCuonSach.TabIndex = 2;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Location = new Point(206, 219);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(115, 43);
            btnMuonSach.TabIndex = 3;
            btnMuonSach.Text = "Cho Mượn";
            btnMuonSach.UseVisualStyleBackColor = true;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // btnCanel
            // 
            btnCanel.Location = new Point(358, 219);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(106, 42);
            btnCanel.TabIndex = 4;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            // 
            // PhieuMuonSach
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 312);
            Controls.Add(btnCanel);
            Controls.Add(btnMuonSach);
            Controls.Add(txbMaCuonSach);
            Controls.Add(txbMaDocGia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "PhieuMuonSach";
            Text = "Phiếu mượn sách";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbMaDocGia;
        private TextBox txbMaCuonSach;
        private Button btnMuonSach;
        private Button btnCanel;
    }
}