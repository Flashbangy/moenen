﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_moenen_forms
{
    public partial class MainForm: UserControl
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.BackColor = Color.FromName("LightBlue");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
