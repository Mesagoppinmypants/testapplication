using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SavingUserSettings.Properties;

namespace TestApplication
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox1();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked_checkBox2();
        }

        private void Do_Checked_checkBox1()
        {
            MessageBox.Show("This function is coming soon.", "Sound Enable/Disable");
        }

        private void Do_Checked_checkBox2()
        {
            MessageBox.Show("This function is coming soon.", "Night Mode");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Your settings will not be saved, but we are working hard to get this working.", "Saving Settings");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
