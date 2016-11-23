using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Apple
    {
        AppleImg appleImg = new AppleImg();
        Image img;
        int x, y;

        public Apple(int x, int y)
        {
            img = appleImg.Image;
            this.x = x;
            this.y = y;
        }

        public Image Img
        {
            get
            {
                return img;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
