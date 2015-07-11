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
    public partial class Exi : Form
    {
        public Exi()
        {
            InitializeComponent();
        }

        private void Exi_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.PlayLooping();
        }
    }
}
