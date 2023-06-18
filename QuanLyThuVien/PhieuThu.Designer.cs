namespace QuanLyThuVien
{
    partial class PhieuMuon
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
            txbMaDocGia = new TextBox();
            label3 = new Label();
            txbMaCuonSach = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 28);
            label1.Name = "label1";
            label1.Size = new Size(299, 35);
            label1.TabIndex = 0;
            label1.Text = "Phiếu Thu Tiền Phạt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 96);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 1;
            label2.Text = "Mã độc giả:";
            // 
            // txbMaDocGia
            // 
            txbMaDocGia.Location = new Point(215, 93);
            txbMaDocGia.Name = "txbMaDocGia";
            txbMaDocGia.Size = new Size(180, 25);
            txbMaDocGia.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 148);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 3;
            label3.Text = "Tiền thu:";
            // 
            // txbMaCuonSach
            // 
            txbMaCuonSach.Location = new Point(215, 150);
            txbMaCuonSach.Name = "txbMaCuonSach";
            txbMaCuonSach.Size = new Size(180, 25);
            txbMaCuonSach.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(122, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Trả tiền";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(248, 229);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // PhieuMuon
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 295);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txbMaCuonSach);
            Controls.Add(label3);
            Controls.Add(txbMaDocGia);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PhieuMuon";
            Text = "Phiếu Thu Tiền Phạt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbMaDocGia;
        private Label label3;
        private TextBox txbMaCuonSach;
        private Button button1;
        private Button button2;
    }
}