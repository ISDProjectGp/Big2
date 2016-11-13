using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big2GameApplication
{
    class CardBackgroundPictureBox : PictureBox
    {
        public CardBackgroundPictureBox(string boxName, bool rotate)
        {
            Name = boxName;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            if (rotate)
            {
                Size = new System.Drawing.Size(140, 100);
            }
            else
            {
                Size = new System.Drawing.Size(100, 140);
            }

            BackColor = System.Drawing.Color.Transparent;
            TabIndex = 1;
            TabStop = false;
        }
        public void setLocation(int x, int y)
        {
            Location = new Point(x, y);


        }
    }
}
