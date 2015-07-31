using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TestApplication
{
    public class GuiController
    {
        public void SoundChecker()
        {
            Options options = new Options();

            if (options.checkBox2.Checked == false)
            {
                SoundPlayer backgroundSound = new SoundPlayer(Program.ResourcesFolder + "background.wav");
                backgroundSound.PlayLooping();
            }
        }
              
        public void SaveState()
        {
            Options options = new Options();

            Properties.Settings.Default.EffectsDisable = options.checkBox1.Checked;
            Properties.Settings.Default.MusicDisable = options.checkBox2.Checked;
            Properties.Settings.Default.NightMode = options.checkBox3.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
