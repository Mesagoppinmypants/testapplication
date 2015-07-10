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

        // First load in
        private void Form1_Load(object sender, EventArgs e)
        {

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
            MessageBox.Show("This function is coming soon.", "Exilos Kun");
            //Form4 exi = new Form4();
            //exi.Show();
        }

        // Iosnowore Kun's YouTube
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 ios = new Form5();
            ios.Show();
        }

          // Options
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 options = new Form6();
            options.Show();
        }

        // Main Text
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
