﻿using System;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // First load in
        private void MainPage_Load(object sender, EventArgs e)
        {
            // Music For First Load in
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            backgroundSound.PlayLooping();
            
            // Saves main page location
            if (Properties.Settings.Default.FormPosition.X != 0 && Properties.Settings.Default.FormPosition.Y != 0)
            {
                this.StartPosition = (FormStartPosition)Properties.Settings.Default["FormPosition"];
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

        // See if we can import these files and use them as strings
        public void Initialize()
        {
            //SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            //SoundPlayer clickSound = new SoundPlayer(@"c:\projects\click.wav");
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
        }

        public void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Save setting
                Properties.Settings.Default["FormSize"] = this.Size;
                Properties.Settings.Default.Save();
            }
            if (this.StartPosition == FormStartPosition.Manual)
            {
                Properties.Settings.Default["FormPosition"] = this.StartPosition;
                Properties.Settings.Default.Save();
            }
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
