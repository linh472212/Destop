﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212403_NTML_BTH3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap=txtTen.Text;

            MessageBox.Show($"Xin Chao Ban {tenDaNhap}.Rat vui duoc gap ban","Thong diep chao mung");
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            btnSaoChep.Text=txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text= txtTen.Text;
        }
    }
}
