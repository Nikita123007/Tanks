using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Projectile
    {
        ProjectileImg projectile = new ProjectileImg();
        int x, y, dirext_x, dirext_y, km;
        const int MaxLong = 100;
        Image currentImg;

        public Image CurrentImage
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
        public int Dirext_x
        {
            get
            {
                return dirext_x;
            }

            set
            {
                km = 0;
                dirext_x = value;
            }
        }
        public int Dirext_y
        {
            get
            {
                return dirext_y;
            }

            set
            {
                km = 0;
                dirext_y = value;
            }
        }
        public Projectile()
        {
            ImageTurn();
            DefaultSeting();
        }
        public void DefaultSeting()
        {
            x = -20;
            y = -20;
            dirext_x = dirext_y = km = 0;
        }
        public void Run()
        {
            ImageTurn();
            x += dirext_x;
            y += dirext_y;
            km += Math.Abs(dirext_x + dirext_y);
            if (km > MaxLong)
                DefaultSeting();
        }
        private void ImageTurn()
        {
            if (Dirext_x == 0)
                if (Dirext_y == 1)
                    currentImg = projectile.ImageDown;
                else
                    currentImg = projectile.ImageUp;
            else
                if (Dirext_x == 1)
                currentImg = projectile.ImageRight;
            else
                currentImg = projectile.ImageLeft;
        }
    }
}
