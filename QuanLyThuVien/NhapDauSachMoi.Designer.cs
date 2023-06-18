namespace QuanLyThuVien
{
    partial class NhapDauSachMoi
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
            groupBox1 = new GroupBox();
            cmbNXB = new ComboBox();
            cmbDauSach = new ComboBox();
            label7 = new Label();
            txbNamXuatBan = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txbSach = new TextBox();
            label2 = new Label();
            numSach = new NumericUpDown();
            label8 = new Label();
            panel1 = new Panel();
            btnCanel = new Button();
            btnNhapSach = new Button();
            txbMoney = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSach).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 56);
            label1.TabIndex = 0;
            label1.Text = "Nhập sách mới:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNXB);
            groupBox1.Controls.Add(cmbDauSach);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txbNamXuatBan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbSach);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(67, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 222);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đầu sách:";
            // 
            // cmbNXB
            // 
            cmbNXB.FormattingEnabled = true;
            cmbNXB.Location = new Point(217, 127);
            cmbNXB.Name = "cmbNXB";
            cmbNXB.Size = new Size(198, 29);
            cmbNXB.TabIndex = 13;
            // 
            // cmbDauSach
            // 
            cmbDauSach.FormattingEnabled = true;
            cmbDauSach.Location = new Point(217, 63);
            cmbDauSach.Name = "cmbDauSach";
            cmbDauSach.Size = new Size(198, 29);
            cmbDauSach.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 127);
            label7.Name = "label7";
            label7.Size = new Size(171, 29);
            label7.TabIndex = 11;
            label7.Text = "Nhà xuất bản:";
            // 
            // txbNamXuatBan
            // 
            txbNamXuatBan.Location = new Point(651, 130);
            txbNamXuatBan.Name = "txbNamXuatBan";
            txbNamXuatBan.Size = new Size(159, 28);
            txbNamXuatBan.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(468, 127);
            label6.Name = "label6";
            label6.Size = new Size(177, 29);
            label6.TabIndex = 9;
            label6.Text = "Năm xuất bản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(468, 63);
            label3.Name = "label3";
            label3.Size = new Size(124, 29);
            label3.TabIndex = 4;
            label3.Text = "Tên sách:";
            // 
            // txbSach
            // 
            txbSach.Location = new Point(592, 62);
            txbSach.Name = "txbSach";
            txbSach.Size = new Size(218, 28);
            txbSach.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(174, 29);
            label2.TabIndex = 1;
            label2.Text = "Tên đầu sách:";
            // 
            // numSach
            // 
            numSach.Location = new Point(267, 17);
            numSach.Name = "numSach";
            numSach.Size = new Size(38, 28);
            numSach.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(136, 18);
            label8.Name = "label8";
            label8.Size = new Size(129, 29);
            label8.TabIndex = 13;
            label8.Text = "Số lượng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCanel);
            panel1.Controls.Add(btnNhapSach);
            panel1.Controls.Add(txbMoney);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(numSach);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(67, 302);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 157);
            panel1.TabIndex = 14;
            // 
            // btnCanel
            // 
            btnCanel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanel.Location = new Point(455, 91);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(90, 45);
            btnCanel.TabIndex = 16;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            btnCanel.Click += btnCanel_Click;
            // 
            // btnNhapSach
            // 
            btnNhapSach.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapSach.Location = new Point(280, 91);
            btnNhapSach.Name = "btnNhapSach";
            btnNhapSach.Size = new Size(124, 45);
            btnNhapSach.TabIndex = 15;
            btnNhapSach.Text = "Nhập sách";
            btnNhapSach.UseVisualStyleBackColor = true;
            btnNhapSach.Click += btnNhapSach_Click;
            // 
            // txbMoney
            // 
            txbMoney.Location = new Point(651, 14);
            txbMoney.Name = "txbMoney";
            txbMoney.Size = new Size(128, 28);
            txbMoney.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(533, 13);
            label9.Name = "label9";
            label9.Size = new Size(92, 29);
            label9.TabIndex = 14;
            label9.Text = "Trị giá:";
            // 
            // NhapDauSachMoi
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 501);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NhapDauSachMoi";
            Text = "Nhập đầu sách mới ";
            Load += NhapDauSachMoi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txbSach;
        private NumericUpDown numSach;
        private Label label2;
        private Label label7;
        private TextBox txbNamXuatBan;
        private Label label6;
        private Label label3;
        private Label label8;
        private Panel panel1;
        private TextBox txbMoney;
        private Label label9;
        private Button btnCanel;
        private Button btnNhapSach;
        private ComboBox cmbDauSach;
        private ComboBox cmbNXB;
    }
}