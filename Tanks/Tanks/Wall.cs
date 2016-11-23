using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Wall
    {
        WallImg wallImg = new WallImg();
        Image currentImg;

        int x, y;


        public Image CurrentImg
        {
            get
            {
                return currentImg;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public Wall(int x, int y)
        {
            this.x = x;
            this.y = y;
            currentImg = wallImg.Image;
        }

    }
}
