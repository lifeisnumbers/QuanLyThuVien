namespace QuanLyThuVien
{
    partial class BaoCaoThangTheLoai
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
            panel1 = new Panel();
            btnExcelSave = new Button();
            label3 = new Label();
            dataBaoCaoThangTheLoai = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaoCaoThangTheLoai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExcelSave);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataBaoCaoThangTheLoai);
            panel1.Location = new Point(12, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 346);
            panel1.TabIndex = 0;
            // 
            // btnExcelSave
            // 
            btnExcelSave.Location = new Point(625, 284);
            btnExcelSave.Name = "btnExcelSave";
            btnExcelSave.Size = new Size(112, 44);
            btnExcelSave.TabIndex = 3;
            btnExcelSave.Text = "Lưu";
            btnExcelSave.UseVisualStyleBackColor = true;
            btnExcelSave.Click += btnExcelSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(349, 291);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 1;
            label3.Text = "Tổng số lượt mượn:";
            // 
            // dataBaoCaoThangTheLoai
            // 
            dataBaoCaoThangTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBaoCaoThangTheLoai.Location = new Point(3, 19);
            dataBaoCaoThangTheLoai.Name = "dataBaoCaoThangTheLoai";
            dataBaoCaoThangTheLoai.RowHeadersWidth = 62;
            dataBaoCaoThangTheLoai.RowTemplate.Height = 33;
            dataBaoCaoThangTheLoai.Size = new Size(770, 253);
            dataBaoCaoThangTheLoai.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(659, 38);
            label1.TabIndex = 1;
            label1.Text = "Báo cáo thống kế tình hình mượn sách theo thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 91);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 2;
            label2.Text = "Ngày lập báo cáo:";
            // 
            // BaoCaoThangTheLoai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "BaoCaoThangTheLoai";
            Text = "BaoCaoThangTheLoai";
            Load += BaoCaoThangTheLoai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaoCaoThangTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private DataGridView dataBaoCaoThangTheLoai;
        private Label label1;
        private Label label2;
        private Button btnExcelSave;
    }
}