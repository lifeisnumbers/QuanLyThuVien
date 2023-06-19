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
            btnCanel = new Button();
            btnNhapDauSach = new Button();
            cmbTenTacGia = new ComboBox();
            label3 = new Label();
            txbTenDauSach = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btncanel1 = new Button();
            btnNhapSach = new Button();
            txbTriGia = new TextBox();
            label9 = new Label();
            soluong = new NumericUpDown();
            label8 = new Label();
            txbNamXuatBan = new TextBox();
            label6 = new Label();
            cmbNhaXuatBan = new ComboBox();
            label5 = new Label();
            txbTenSach = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soluong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(503, 59);
            label1.TabIndex = 0;
            label1.Text = "Nhập đầu sách mới ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCanel);
            groupBox1.Controls.Add(btnNhapDauSach);
            groupBox1.Controls.Add(cmbTenTacGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbTenDauSach);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 151);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin đầu sách:";
            // 
            // btnCanel
            // 
            btnCanel.Location = new Point(368, 109);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(77, 25);
            btnCanel.TabIndex = 4;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            btnCanel.Click += btnCanel_Click;
            // 
            // btnNhapDauSach
            // 
            btnNhapDauSach.Location = new Point(285, 109);
            btnNhapDauSach.Name = "btnNhapDauSach";
            btnNhapDauSach.Size = new Size(77, 25);
            btnNhapDauSach.TabIndex = 3;
            btnNhapDauSach.Text = "Nhập";
            btnNhapDauSach.UseVisualStyleBackColor = true;
            btnNhapDauSach.Click += btnNhapDauSach_Click;
            // 
            // cmbTenTacGia
            // 
            cmbTenTacGia.FormattingEnabled = true;
            cmbTenTacGia.Location = new Point(285, 73);
            cmbTenTacGia.Name = "cmbTenTacGia";
            cmbTenTacGia.Size = new Size(181, 29);
            cmbTenTacGia.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(111, 70);
            label3.Name = "label3";
            label3.Size = new Size(146, 29);
            label3.TabIndex = 2;
            label3.Text = "Tên tác giả:";
            // 
            // txbTenDauSach
            // 
            txbTenDauSach.Location = new Point(285, 36);
            txbTenDauSach.Name = "txbTenDauSach";
            txbTenDauSach.Size = new Size(181, 28);
            txbTenDauSach.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 38);
            label2.Name = "label2";
            label2.Size = new Size(174, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên đầu sách:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btncanel1);
            panel1.Controls.Add(btnNhapSach);
            panel1.Controls.Add(txbTriGia);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(soluong);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txbNamXuatBan);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbNhaXuatBan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txbTenSach);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 291);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // btncanel1
            // 
            btncanel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncanel1.Location = new Point(313, 191);
            btncanel1.Name = "btncanel1";
            btncanel1.Size = new Size(90, 45);
            btncanel1.TabIndex = 7;
            btncanel1.Text = "Hủy";
            btncanel1.UseVisualStyleBackColor = true;
            btncanel1.Click += btncanel1_Click;
            // 
            // btnNhapSach
            // 
            btnNhapSach.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapSach.Location = new Point(160, 191);
            btnNhapSach.Name = "btnNhapSach";
            btnNhapSach.Size = new Size(124, 45);
            btnNhapSach.TabIndex = 6;
            btnNhapSach.Text = "Nhập sách";
            btnNhapSach.UseVisualStyleBackColor = true;
            // 
            // txbTriGia
            // 
            txbTriGia.Location = new Point(425, 111);
            txbTriGia.Name = "txbTriGia";
            txbTriGia.Size = new Size(100, 28);
            txbTriGia.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(358, 113);
            label9.Name = "label9";
            label9.Size = new Size(92, 29);
            label9.TabIndex = 16;
            label9.Text = "Trị giá:";
            // 
            // soluong
            // 
            soluong.Location = new Point(222, 114);
            soluong.Name = "soluong";
            soluong.Size = new Size(37, 28);
            soluong.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(119, 114);
            label8.Name = "label8";
            label8.Size = new Size(129, 29);
            label8.TabIndex = 14;
            label8.Text = "Số lượng:";
            // 
            // txbNamXuatBan
            // 
            txbNamXuatBan.Location = new Point(282, 62);
            txbNamXuatBan.Name = "txbNamXuatBan";
            txbNamXuatBan.Size = new Size(137, 28);
            txbNamXuatBan.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(164, 62);
            label6.Name = "label6";
            label6.Size = new Size(177, 29);
            label6.TabIndex = 4;
            label6.Text = "Năm xuất bản:\r\n";
            // 
            // cmbNhaXuatBan
            // 
            cmbNhaXuatBan.FormattingEnabled = true;
            cmbNhaXuatBan.Location = new Point(427, 14);
            cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            cmbNhaXuatBan.Size = new Size(130, 29);
            cmbNhaXuatBan.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(305, 16);
            label5.Name = "label5";
            label5.Size = new Size(171, 29);
            label5.TabIndex = 2;
            label5.Text = "Nhà xuất bản:";
            // 
            // txbTenSach
            // 
            txbTenSach.Location = new Point(124, 14);
            txbTenSach.Name = "txbTenSach";
            txbTenSach.Size = new Size(137, 28);
            txbTenSach.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 16);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 0;
            label4.Text = "Tên sách:";
            // 
            // NhapDauSachMoi
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 535);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "NhapDauSachMoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập đầu sách mới ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soluong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txbTenDauSach;
        private Label label2;
        private Button btnCanel;
        private Button btnNhapDauSach;
        private ComboBox cmbTenTacGia;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private TextBox txbTenSach;
        private ComboBox cmbNhaXuatBan;
        private Label label5;
        private Label label6;
        private TextBox txbNamXuatBan;
        private NumericUpDown soluong;
        private Label label8;
        private TextBox txbTriGia;
        private Label label9;
        private Button btnNhapSach;
        private Button btncanel1;
    }
}