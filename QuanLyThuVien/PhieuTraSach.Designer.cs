namespace QuanLyThuVien
{
    partial class PhieuTraSach
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
            btnCanel = new Button();
            btnMuonSach = new Button();
            txbMaCuonSach = new TextBox();
            txbMaDocGia = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCanel
            // 
            btnCanel.Location = new Point(429, 228);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(106, 42);
            btnCanel.TabIndex = 11;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Location = new Point(277, 228);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(115, 43);
            btnMuonSach.TabIndex = 10;
            btnMuonSach.Text = "Trả sách";
            btnMuonSach.UseVisualStyleBackColor = true;
            // 
            // txbMaCuonSach
            // 
            txbMaCuonSach.Location = new Point(359, 148);
            txbMaCuonSach.Name = "txbMaCuonSach";
            txbMaCuonSach.Size = new Size(185, 25);
            txbMaCuonSach.TabIndex = 8;
            // 
            // txbMaDocGia
            // 
            txbMaDocGia.Location = new Point(359, 101);
            txbMaDocGia.Name = "txbMaDocGia";
            txbMaDocGia.Size = new Size(185, 25);
            txbMaDocGia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(204, 149);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 9;
            label3.Text = "Mã cuốn sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(233, 99);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 7;
            label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 35);
            label1.Name = "label1";
            label1.Size = new Size(247, 40);
            label1.TabIndex = 5;
            label1.Text = "Phiếu trả sách";
            // 
            // PhieuTraSach
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 324);
            Controls.Add(btnCanel);
            Controls.Add(btnMuonSach);
            Controls.Add(txbMaCuonSach);
            Controls.Add(txbMaDocGia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "PhieuTraSach";
            Text = "Phiếu Trả Sách";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCanel;
        private Button btnMuonSach;
        private TextBox txbMaCuonSach;
        private TextBox txbMaDocGia;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}