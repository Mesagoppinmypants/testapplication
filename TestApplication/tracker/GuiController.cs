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
        Options Op = new Options();

        public void DisableSoundCheck(object sender, EventArgs e)
        //public void DisableSoundCheck()
        {
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wave");

            if (Op.checkBox2.Checked == true)
            {
                backgroundSound.Stop();
            }
            else
            {
                backgroundSound.PlayLooping();
            }
        }
    }
}
