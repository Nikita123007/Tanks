using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Packman
    {
        PackmanImg packmanImg = new PackmanImg();
        Image[] img;
        Image currentImg;
        int x, y, dirext_x, dirext_y, k, next_dirext_x, next_dirext_y;
        static Random r;
        int sizeField;

        public Packman(int sizeField)
        {
            r = new Random();
            next_dirext_x = 0;
            next_dirext_y = -1;
            dirext_x = 0;
            dirext_y = -1;
            x = (sizeField - 20)/2;
            y = sizeField - 20;
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
                dirext_y = value;
            }
        }
        public Image CurrentImg
        {
            get
            {
                return currentImg;
            }
        }
        public int Next_dirext_x
        {
            set
            {
                next_dirext_x = value;
            }
        }
        public int Next_dirext_y
        {
            set
            {
                next_dirext_y = value;
            }
        }
        private void PutCerrentImg()
        {
            currentImg = img[k];
            k = ++k % 5;
        }
        public void Run()
        {
            x += Dirext_x;
            y += Dirext_y;
            Tranceparent();
            Turn();
            ImageTurn();
            PutCerrentImg();
        }
        public void Turn()
        {
            bool turn = false;
            if ((x % 40 == 0) && (y % 40 == 0))
                turn = true;
            if ((dirext_x == 0) && (next_dirext_x == 0))
                turn = true;
            if ((dirext_y == 0) && (next_dirext_y == 0))
                turn = true;
            if (turn)
            {
                dirext_x = next_dirext_x;
                dirext_y = next_dirext_y;
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
        public void ImageTurn()
        {
            if (Dirext_x == 0)
                if (Dirext_y == 1)
                    img = packmanImg.ImageDown;
                else
                    img = packmanImg.ImageUp;
            else
                if (Dirext_x == 1)
                img = packmanImg.ImageRight;
            else
                img = packmanImg.ImageLeft;
        }
    }
}
