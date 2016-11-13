using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big2GameApplication
{
    public class MyBox : PictureBox
    {
        private bool release = false;
        private int _value = 0;

        public MyBox(String BoxName,int value)
        {
            Name = BoxName;
            BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(100, 140);
            TabIndex = 1;
            TabStop = false;
            _value = value;
        }
        public void setRelease()
        {
            release = true;
        }
        public bool getRelease()
        {
            return release;
        }
        public int getValue()
        {
            return _value;
        }
        public void setLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
        private Boolean selected = false;
        public Boolean isSelected()
        {
            return selected;
        }
        public void setSelected()
        {
            if (selected)
            {
                selected = false;
            }
            else
            {
                selected = true;
            }

        }
        public void clearSelected()
        {
           
            selected = false;
        }
    }
}
