﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btnQDdocgia_Click(object sender, EventArgs e)
        {

            btnThayDoiQuyDinh1.Visible = true;
            btnThayDoiQuyDinh2.Visible = false;
            btnThayDoiQuyDinh3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;


        }

        private void btnQDnhapsach_Click(object sender, EventArgs e)
        {

            btnThayDoiQuyDinh1.Visible = false;
            btnThayDoiQuyDinh2.Visible = false;
            btnThayDoiQuyDinh3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void btnMuonTraSach_Click(object sender, EventArgs e)
        {

            btnThayDoiQuyDinh1.Visible = false;
            btnThayDoiQuyDinh2.Visible = true;
            btnThayDoiQuyDinh3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void btnThayDoiQuyDinh3_Click(object sender, EventArgs e)
        {

        }

        private void btnThayDoiQuyDinh2_Click(object sender, EventArgs e)
        {

        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {

        }
    }
}
