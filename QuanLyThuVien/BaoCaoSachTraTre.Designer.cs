﻿namespace QuanLyThuVien
{
    partial class BaoCaoSachTraTre
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
            dataSachTraTre = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSachTraTre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 24);
            label1.Name = "label1";
            label1.Size = new Size(696, 56);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo thống kê sách trả trễ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 72);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 1;
            label2.Text = "Ngày báo cáo:\r\n";
            // 
            // dataSachTraTre
            // 
            dataSachTraTre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSachTraTre.Location = new Point(73, 107);
            dataSachTraTre.Name = "dataSachTraTre";
            dataSachTraTre.RowHeadersWidth = 62;
            dataSachTraTre.RowTemplate.Height = 25;
            dataSachTraTre.Size = new Size(560, 227);
            dataSachTraTre.TabIndex = 2;
            dataSachTraTre.CellContentClick += dataSachTraTre_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(440, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // BaoCaoSachTraTre
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 388);
            Controls.Add(btnSave);
            Controls.Add(dataSachTraTre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "BaoCaoSachTraTre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo sách trả trễ";
            Load += BaoCaoSachTraTre_Load;
            ((System.ComponentModel.ISupportInitialize)dataSachTraTre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataSachTraTre;
        private Button btnSave;
    }
}