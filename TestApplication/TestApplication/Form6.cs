﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox1();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox2();
        }

        private void Do_Checked_checkBox1()
        {
            MessageBox.Show("This function is coming soon.", "Sound");
        }

        private void Do_Checked_checkBox2()
        {
            MessageBox.Show("This function is coming soon.", "Night Mode");
        }
    }
}