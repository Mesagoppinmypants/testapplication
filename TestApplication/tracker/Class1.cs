using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TestApplication
{
    class Class1: TestApplication.Options
    {
        private void MainPage_Load(object sender, EventArgs e)
        {
            // Music For First Load in
            SoundPlayer backgroundSound = new SoundPlayer(@"c:\projects\background.wav");

            //backgroundSound.Stop(); // This will have to do for now until we can fix what's below.

            if (checkBox2.Checked == true)
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
