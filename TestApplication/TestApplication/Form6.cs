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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // Disable sound effects
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox1();
        }

        // Disables music
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox2();
        }

        // Enables nightmode
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox3();
        }

        
        private void Do_Checked_checkBox1()
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("This function is coming soon.", "Music Enable/Disable");
        }

        
        private void Do_Checked_checkBox2()
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("This function is coming soon.", "Night Mode");
        }

        
        private void Do_Checked_checkBox3()
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("This function is coming soon.", "All Sound Enable/Disable");
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
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Properties.Settings.Default.textbox = checkBox1.Checked;
        }
    }
}
