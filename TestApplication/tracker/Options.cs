﻿using System;
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
            //if (comboBox1.SelectedItem.ToString() == "English")
            //{
                //this.TriggerLanguageChange("en");
            }
/*            else if (comboBox1.SelectedItem.ToString() == "Spanish")
            {
                this.TriggerLanguageChange("sp");
            }
        }
       
        public class LanguageArts : EventArgs
        {
            string _languageSymbol;
        /// <summary>
        /// Gets the language symble.
        /// </summary>
        public string LanguageSymbol
        {
            get { return _languageSymbol; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageArgs"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public LanguageArgs(string symbol)
        {
            this._languageSymbol = symbol;
        }
}
/// <summary>
/// A Base class that your class should derivative from.
/// </summary>
/// <param name="languageSymbol"></param>
public class BaseLanguageForm:Form
{
        /// <summary>
        /// Triggers the language change event.
        /// </summary>
        /// <param name="languageSymbol">The language Symbol.</param>
        protected void TriggerLanguageChange(string languageSymbol)
        {
            if (Options.onLanguageChanged != null)
            {
                LanguageArgs args = new LanguageArgs(languageSymbol);
                Options.onLanguageChanged(this, args);
            }
        }

        protected static event EventHandler<LanguageArgs> onLanguageChanged;

        public BaseLanguageForm()
        {
            BaseLanguageForm.onLanguageChanged += new EventHandler<LanguageArgs>(BaseLanguageForm_onLanguageChanged);
        }

        void BasicLanguageForm_onLanguageChanged(object sender, LanguageArgs e)
        {
            string lang = e.LanguageSymbol;
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager crm = new ComponentResourceManager(typeof(Options));
                crm.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
*/
        // This is when the page closes
        public void Options_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}