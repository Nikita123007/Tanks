using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class FireTank
    {
        FireTankImg fireTankImg = new FireTankImg();
        Image[] img;
        Image currentImg;
        int x, y, k;

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
        public FireTank(int x, int y)
        {
            img = fireTankImg.Image;
            PutCerrentImg();
            this.x = x;
            this.y = y;
        }     
        public void Fire()
        {
            PutCerrentImg();
        }
        private void PutCerrentImg()
        {
            currentImg = img[k];
            k = ++k % 6;
        }
    }
}
