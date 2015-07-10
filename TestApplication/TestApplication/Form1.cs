using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Box1_Checked();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function is coming soon.", "YouTube Button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function is coming soon.", "Facebook Button");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function is coming soon.", "Twitter Button");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Box1_Checked();
        }

        private void checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            Box2_Checked();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Box3_Checked();
        }

        private void Box1_Checked()
        {
            button1.Enabled = checkBox1.Checked;
        }

        private void Box2_Checked()
        {
            button2.Enabled = checkBox2.Checked;
        }

        private void Box3_Checked()
        {
            button3.Enabled = checkBox3.Checked;
        }
    }
}
