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
    public partial class Extras : Form
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // About
            this.Close();
            About about = new About();
            about.Show();
        }
    }
}
