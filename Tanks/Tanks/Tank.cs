using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun, ITurn, ITranceparent, CurrentImg, ITurnArround
    {
        private TankImg tankImg = new TankImg();
        protected Image[] img;
        protected Image currentImg;
        protected int x, y, dirext_x, dirext_y, k;
        protected static Random r;
        protected int sizeField;

        public Tank(int sizeField, int x, int y, int dirext_x, int dirext_y)
        {
            r = new Random();
            this.dirext_x = dirext_x;
            this.dirext_y = dirext_y;
            this.x = x;
            this.y = y;
            this.sizeField = sizeField;
            ImageTurn();
            PutCerrentImg();
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
        public int Dirext_x
        {
            get
            {
                return dirext_x;
            }

            set
            {
                if (value == 1 || value == -1 || value == 0)
                    dirext_x = value;
                else
                    dirext_x = 0;
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
                if (value == 1 || value == -1 || value == 0)
                    dirext_y = value;
                else
                    dirext_y = 0;
            }
        }
        public Image CurrentImg
        {
            get
            {
                return currentImg;
            }
        }        
        public void Run()
        {
            x += Dirext_x;
            y += Dirext_y;
            Tranceparent();
            ImageTurn();
            PutCerrentImg();
            if ((x % 40 == 0) && (y % 40 == 0))
                Turn();
        }
        public void Turn()
        {
            if (r.Next(1000) < 300)
                return;
            if (Dirext_y == 0)
            {
                Dirext_x = 0;
                while (Dirext_y == 0)
                    Dirext_y = r.Next(-1, 2);
                return;
            }
            if (Dirext_x == 0)
            {
                Dirext_y = 0;
                while (Dirext_x == 0)
                    Dirext_x = r.Next(-1, 2);
                return;
            }
        }
        public void Tranceparent()
        {
            if ((x == -1) && (Dirext_x == -1))
                x = sizeField - 1;
            if ((x == sizeField + 1 - 20) && (dirext_x == 1))
                x = 1 - 20;
            if ((y == -1) && (Dirext_y == -1))
                y = sizeField - 1;
            if ((y == sizeField + 1 - 20) && (Dirext_y == 1))
                y = 1 - 20;

        }     
        public void TurnArround()
        {
            Dirext_x = -1 * Dirext_x;
            Dirext_y = -1 * Dirext_y;
        }
        protected void PutCerrentImg()
        {
            currentImg = img[k];
            k = ++k % 5;
        }
        private void ImageTurn()
        {
            if (Dirext_x == 0)
                if (Dirext_y == 1)
                    img = tankImg.ImageDown;
                else
                    img = tankImg.ImageUp;
            else
                if (Dirext_x == 1)
                    img = tankImg.ImageRight;
                else
                    img = tankImg.ImageLeft;
        }
    }
}
