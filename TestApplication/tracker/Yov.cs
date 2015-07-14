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
    public partial class Yov : Form
    {
        //Options options = new Options();

        public Yov()
        {
            InitializeComponent();
        }

        private void Yov_FormLoad(object sender, EventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.Stop();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Yov_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.checkBox1.Visible = true;
        }

        private void Yov_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            //backgroundSound.PlayLooping();
            //Do_Checked_checkBox2();
        }
    }
}