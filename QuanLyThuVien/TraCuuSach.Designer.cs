namespace QuanLyThuVien
{
    partial class TraCuuSach
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
            dataDanhSachSach = new DataGridView();
            cmbTimKiemTheo = new ComboBox();
            label2 = new Label();
            txbTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDanhSachSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 20);
            label1.Name = "label1";
            label1.Size = new Size(317, 55);
            label1.TabIndex = 0;
            label1.Text = "Tra cứu sách";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataDanhSachSach);
            groupBox1.Controls.Add(cmbTimKiemTheo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbTimKiem);
            groupBox1.Location = new Point(22, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 409);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sách:";
            // 
            // dataDanhSachSach
            // 
            dataDanhSachSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDanhSachSach.Location = new Point(80, 107);
            dataDanhSachSach.Name = "dataDanhSachSach";
            dataDanhSachSach.RowHeadersWidth = 51;
            dataDanhSachSach.RowTemplate.Height = 29;
            dataDanhSachSach.Size = new Size(619, 277);
            dataDanhSachSach.TabIndex = 3;
            // 
            // cmbTimKiemTheo
            // 
            cmbTimKiemTheo.FormattingEnabled = true;
            cmbTimKiemTheo.Location = new Point(494, 50);
            cmbTimKiemTheo.Name = "cmbTimKiemTheo";
            cmbTimKiemTheo.Size = new Size(151, 32);
            cmbTimKiemTheo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 53);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 1;
            label2.Text = "Tìm sách:";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(190, 47);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(280, 30);
            txbTimKiem.TabIndex = 0;
            // 
            // TraCuuSach
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 540);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TraCuuSach";
            Text = "Tra cứu sách";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataDanhSachSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataDanhSachSach;
        private ComboBox cmbTimKiemTheo;
        private Label label2;
        private TextBox txbTimKiem;
    }
}