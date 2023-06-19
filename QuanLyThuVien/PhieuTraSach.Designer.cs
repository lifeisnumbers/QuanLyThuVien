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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuTraSach));
            btnCanel = new Button();
            btnMuonSach = new Button();
            txbMaCuonSach = new TextBox();
            txbMaDocGia = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnCanel
            // 
            btnCanel.Location = new Point(349, 228);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(106, 42);
            btnCanel.TabIndex = 4;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            btnCanel.Click += btnCanel_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Location = new Point(205, 227);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(115, 43);
            btnMuonSach.TabIndex = 3;
            btnMuonSach.Text = "Trả sách";
            btnMuonSach.UseVisualStyleBackColor = true;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // txbMaCuonSach
            // 
            txbMaCuonSach.Location = new Point(323, 146);
            txbMaCuonSach.Name = "txbMaCuonSach";
            txbMaCuonSach.Size = new Size(185, 21);
            txbMaCuonSach.TabIndex = 2;
            // 
            // txbMaDocGia
            // 
            txbMaDocGia.Location = new Point(323, 97);
            txbMaDocGia.Name = "txbMaDocGia";
            txbMaDocGia.Size = new Size(185, 21);
            txbMaDocGia.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(181, 148);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 9;
            label3.Text = "Mã cuốn sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(205, 99);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 7;
            label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 30);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 5;
            label1.Text = "Phiếu trả sách";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(442, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(78, 47);
            panel1.TabIndex = 12;
            // 
            // PhieuTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 324);
            Controls.Add(panel1);
            Controls.Add(btnCanel);
            Controls.Add(btnMuonSach);
            Controls.Add(txbMaCuonSach);
            Controls.Add(txbMaDocGia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "PhieuTraSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu Trả Sách";
            FormClosing += PhieuTraSach_FormClosing;
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
        private Panel panel1;
    }
}