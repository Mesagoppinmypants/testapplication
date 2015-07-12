using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Resources;
using System.IO;

namespace TestApplication
{
    //public partial class MainPage : Form
    public partial class MainPage : Form
    {
        public MainPage()
        {
            // Timer for background images
       //     this.BackgroundImage = Properties.Resources.Background1;
            InitializeComponent();
        /*    Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
        }

        // Background images
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.Background1);
            b1.Add(Properties.Resources.Background2);
            int index = DateTime.Now.Second % 2;
            this.BackgroundImage = b1[index]; */
        }

        // First load in
        private void MainPage_Load(object sender, EventArgs e)
        {
           
            // Music For First Load in
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            //SoundPlayer backgroundSound1 = new SoundPlayer(@"c:\projects\test.wav");

            backgroundSound.PlayLooping(); // This will have to do for now until we can fix what's below.
            //backgroundSound.PlaySync();
            //backgroundSound1.PlaySync();

            // checkBox2 = CheckBox Options.checkBox2
            //if (checkBox2.Checked == true)
            {
                //backgroundSound.Stop();
            }
           // else
            {
                //backgroundSound.PlayLooping();

                 //Saves main page location
                if (Properties.Settings.Default.FormPosition.X != 0 && Properties.Settings.Default.FormPosition.Y != 0)
                {
                    this.StartPosition = (FormStartPosition)Properties.Settings.Default["FormPosition"];
                }
                timer1.Start();
                timer1.Enabled = true;
            }
        }

        // Yoverion Kun's YouTube
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.Stop();
            Yov yov = new Yov();
            yov.Show();
        }

        // Solvaxus Kun's YouTube
        private void button2_Click(object sender, EventArgs e)
        {
            Solv solv = new Solv();
            solv.Show();
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.Stop();
        }

        // Exilos Kun's YouTube
        private void button3_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
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

        // Main Text - Keep this empty as nothing should happen.
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Extras
        private void button6_Click(object sender, EventArgs e)
        {
            Extras extras = new Extras();
            extras.Show();
        }

        public void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.StartPosition == FormStartPosition.Manual)
            {
                Properties.Settings.Default["FormPosition"] = this.StartPosition;
                Properties.Settings.Default.Save();
            }
        }

        // Yoverion Kun
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.Black;
            //this.BackgroundImage = Properties.Resources.Background1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.Red;
        }

        // Exilos Kun
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.Red;
        }

        // Solvaxus Kun
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = System.Drawing.Color.Black;
            this.BackgroundImage = Properties.Resources.Background1;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = System.Drawing.Color.Red;
            this.BackgroundImage = Properties.Resources.Background;
        }

        // Iosnowore Kun
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = System.Drawing.Color.Black;
            this.BackgroundImage = Properties.Resources.Background2;
        
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = System.Drawing.Color.Red;
            this.BackgroundImage = Properties.Resources.Background;
        }

        // Options
        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = System.Drawing.Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = System.Drawing.Color.Red;
        }

        // Extras
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.ForeColor = System.Drawing.Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = System.Drawing.Color.Black;
            this.BackgroundImage = Properties.Resources.Background1;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.ForeColor = System.Drawing.Color.Black;
            this.BackgroundImage = Properties.Resources.Background2;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.ForeColor = System.Drawing.Color.Black;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.ForeColor = System.Drawing.Color.Black;
        }

        // Title color change
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Black)
            {
                label1.ForeColor = Color.Red;
                timer1.Interval = 500;
            }
            else
            {
                label1.ForeColor = Color.Black;
                timer1.Interval = 500;
            }
            //Random rand = new Random();
            //int A = rand.Next(0, 255);
            //int R = rand.Next(0, 255);
            //int G = rand.Next(0, 255);
            //int B = rand.Next(0, 255);
            //label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        // ----------------------------------------------------------- Try to get sound by string. ---------------------------------------------------------------------------------------------------------------------
/*        private ResourceManager DJOResourcesManager;

        private bool _soundOption;

        public bool soundOption
        {
            get
            {
                return _soundOption;
            }
            set
            {
                _soundOption = value;
                SetAppSetting("SoundEnable", ((_soundOption == true) ? "true : "false"));

            }
        }
        
        DJOResourcesManager = new ResourceManager("DJO Tracker.DJORes", Assembly.GetExecutingAssembly());


        public Stream GetSound(string filename)
        {
            byte[] x = ((byte[])DJOResourcesManager.GetObject(filename));

            if (x == null) { return null; }

            return new MemoryStream(x);
        }
        
        public void PlaySound(string filename)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(this.GetSound(filename));
            if (this.soundOption) { player.Play (); }
        }
        
        public void SetAppSetting(string key, string value)
        {
            if (config.AppSettings.Settings[key] != null)
            {
                config.AppSettings.Settings.Remove(key);
            }
            config.AppSettings.Settings.Add(key, value);

            try
            {
                config.Save(ConfigurationSaveMode.Modified);*/
    }
}
