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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // First load in
        private void MainPage_Load(object sender, EventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            //clickSound.Play();
            backgroundSound.PlayLooping();
        }

        // Yoverion Kun's YouTube
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This function is coming soon.", "YouTube Button");
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.Stop();
            Yov yov = new Yov();
            yov.Show();
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            {
                //SoundPlayer s = new SoundPlayer(ofd.FileName);
                //s.Play();
                //s.PlayLooping();
            }
        }

        // Solvaxus Kun's YouTube
        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This function is coming soon.", "Facebook Button");
            Solv solv = new Solv();
            solv.Show();
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.Stop();
        }

        // Exilos Kun's YouTube
        private void button3_Click(object sender, EventArgs e)
        {
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Asterisk.Play();
            SystemSounds.Hand.Play(); // Main One for unavailable functions.
            //SystemSounds.Beep.Play();
            // Add Music
            //SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            //backgroundSound.Stop();
            //SoundPlayer simpleSound = new SoundPlayer("test.wav"); -- Find a way to make a string
            //simpleSound.PlayLooping();
            MessageBox.Show("This function is currently unavailable.", "Exilos Kun");
            //Form4 exi = new Form4();
            //exi.Show();
        }

        // Iosnowore Kun's YouTube
        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.Stop();
            Ios ios = new Ios();
            ios.Show();
        }

        // Options
        private void button5_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        // Main Text
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Extras
        private void button6_Click(object sender, EventArgs e)
        {
            Form7 extras = new Form7();
            extras.Show();
        }

        // See if we can import these files and use them as strings
        public void Initialize()
        {          
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            SoundPlayer clickSound = new SoundPlayer(@"c:\projects\click.wav");
        }
    }
}
