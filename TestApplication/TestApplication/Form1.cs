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
            Box1_Checked(); // This isn't loading..
        }

        // Yoverion Kun's YouTube
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This function is coming soon.", "YouTube Button");
            Form2 yov = new Form2();
            yov.Show();
        }

        // Solvaxus Kun's YouTube
        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This function is coming soon.", "Facebook Button");
            Form3 solv = new Form3();
            solv.Show();
        }

        // Exilos Kun's YouTube
        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This function is coming soon.", "Twitter Button");
            Form4 exi = new Form4();
            exi.Show();
        }

        // Iosnowore Kun's YouTube
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 ios = new Form5();
            ios.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Box1_Checked();
        }

        private void Box1_Checked()
        {
            button1.Enabled = checkBox1.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
