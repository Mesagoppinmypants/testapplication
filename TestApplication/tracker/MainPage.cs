using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

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
        //int mouseX = 0, MouseY = 0;
        //bool mouseDown;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Music For First Load in
            Options options = new Options();
            SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.wav");

            if (!Properties.Settings.Default.MusicDisable)
            {
                backgroundSound.PlayLooping();
            }
            else
            {
                backgroundSound.Stop();
            }

            //Saves main page location
            if (Properties.Settings.Default.FormPosition.X != 0 && Properties.Settings.Default.FormPosition.Y != 0)
            {
                StartPosition = (FormStartPosition)Properties.Settings.Default["FormPosition"];
            }
            timer1.Start();
            timer1.Enabled = true;
        }

        // Yoverion Kun's YouTube
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.mp3");
            backgroundSound.Stop();
            Yov yov = new Yov();
            yov.Show();
        }

        // Solvaxus Kun's YouTube
        private void button2_Click(object sender, EventArgs e)
        {
            Solv solv = new Solv();
            solv.Show();
            SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.mp3");
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
            SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.mp3");
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
            if (StartPosition == FormStartPosition.Manual)
            {
                Properties.Settings.Default["FormPosition"] = StartPosition;
                Properties.Settings.Default.Save();
            }
        }

        // Exilos
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        // Yoverion Kun
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        // Solvaxus Kun
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        // Iosnowore Kun
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
        
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        // Options
        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Yellow;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Black;
        }

        // Extras
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Yellow;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Yellow;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Yellow;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.Yellow;
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

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Yellow;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.Yellow;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Black;
        }

        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            //mouseDown = true;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
        //    if (mouseDown)
            {
        //        mouseX = MousePosition.X - 225;
         //       MouseY = MousePosition.Y - 225;

          //      this.SetDesktopLocation(mouseX, MouseY);
            }
        }

        private void MainPage_MouseUp(object sender, MouseEventArgs e)
        {
         //   mouseDown = false;
        }
    }
}
