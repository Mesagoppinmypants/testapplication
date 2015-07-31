using System;
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

        public void Options_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.EffectsDisable;
            checkBox2.Checked = Properties.Settings.Default.MusicDisable;
            checkBox3.Checked = Properties.Settings.Default.NightMode;
            comboBox1.SelectedItem = Properties.Settings.Default.LanguageSelect;
        }
        // Disable sound effects
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox1();
        }

        // Disables music
        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Enables nightmode
        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox3();
        }


        public void Do_Checked_checkBox1()
        {
        }

        public void Do_Checked_checkBox2()
        {
            SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.wav");
            //if (!Properties.Settings.Default.MusicDisable)
            {
                //backgroundSound.Play();
            }
            //else
            {
                backgroundSound.Stop();
            }
        }


        public void Do_Checked_checkBox3()
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
                SystemSounds.Hand.Play();
                MessageBox.Show("This function is coming soon.", "Night Mode Enable/Disable");
            }
        }

        // When the user clicks the "apply" button
        public void button1_Click(object sender, EventArgs e)
        {
            GuiController controller = new GuiController();

            Close();
            controller.SaveState();
            Do_Checked_checkBox2();

            SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.wav");
            if (checkBox2.Checked == false)
                backgroundSound.Play();
        }

        // This is when the user changes the language option.
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // This is when the page closes
        public void Options_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}