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
    public partial class Solv : Form
    {
        public Solv()
        {
            InitializeComponent();
        }

        private void Solv_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuiController control = new GuiController();
            control.SoundChecker();
        }
    }
}
