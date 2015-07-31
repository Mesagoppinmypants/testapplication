using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TestApplication
{
    public partial class Ios : Form
    {
        public Ios()
        {
            InitializeComponent();
        }

        private void Ios_Load(object sender, EventArgs e)
        {

        }

        private void Ios_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuiController control = new GuiController();
            control.SoundChecker();
        }
    }
}
