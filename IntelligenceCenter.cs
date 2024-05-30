using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR6._2_submarine;

namespace PR6._2_submarine
{
    internal class IntelligenceCenter
    {
        public bool IsOn { get; set; } = false;

        void RadarSpot()
        {
            Random random = new Random();
            PictureBox pbSpot = new PictureBox();
            int x = random.Next(250, 290);
            int y = random.Next(25, 75);
            pbSpot.Location = new System.Drawing.Point(x,y);
        }
    }
}
