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
            if (Properties.Settings.Default.FormSize.Width != 0 && Properties.Settings.Default.FormSize.Height != 0)
            {
                this.Size = (Size)Properties.Settings.Default["FormSize"];
            }
        }

        private void Ios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default["FormSize"] = this.Size;
            }
        }

        private void Ios_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.PlayLooping();
        }
    }
}
