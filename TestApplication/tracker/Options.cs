﻿using System;
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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.EffectsDisable;
            checkBox2.Checked = Properties.Settings.Default.MusicDisable;
            checkBox3.Checked = Properties.Settings.Default.NightMode;
            //comboBox1.SelectedItem = Properties.Settings.Default.LanguageSelect; -- Enable when saving is fixed below.
        }
        // Disable sound effects
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox1();
        }

        // Disables music
        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox2();
            //SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
            //backgroundSound.Stop();
        }

        // Enables nightmode
        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox3();
        }

        
        public void Do_Checked_checkBox1()
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("This function is coming soon.", "Sound Effects Enable/Disable");
        }


        public void Do_Checked_checkBox2()
        {
            //SystemSounds.Hand.Play();
            //MessageBox.Show("This function is coming soon.", "Disable Music");
            if (checkBox2.Checked == true)
            {
                SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
                //TestApplication.Mainpage.backgroundSound.Stop();
                backgroundSound.Stop();
            }
            else
            {
                SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");
                backgroundSound.Play();
            }
        }

        
        public void Do_Checked_checkBox3()
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("This function is coming soon.", "Night Mode Enable/Disable");
        }

        // When the user clicks the "apply" button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SystemSounds.Hand.Play();
            MessageBox.Show("The save settings function has not been implemented yet.", "Saving Settings");
        }

        // This is when the user changes the language option.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // This is when the page closes
        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.EffectsDisable = checkBox1.Checked;
            Properties.Settings.Default.MusicDisable = checkBox2.Checked;
            Properties.Settings.Default.NightMode = checkBox3.Checked;
           // Properties.Settings.Default.LanguageSelect = comboBox1.SelectedItem; -- FIXME
            Properties.Settings.Default.Save();
        }
    }
}