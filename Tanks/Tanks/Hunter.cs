using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Hunter : Tank
    {
        private HunterImg hunterImg = new HunterImg();     
        public Hunter(int sizeField, int x, int y, int dirext_x, int dirext_y) : base (sizeField, x, y, dirext_x, dirext_y)
        {
            ImageTurn();
            PutCerrentImg();
        }
        public void Run(int target_x, int target_y)
        {
            x += Dirext_x;
            y += Dirext_y;
            Tranceparent();
            ImageTurn();
            PutCerrentImg();
            if ((x % 40 == 0) && (y % 40 == 0))
                Turn(target_x, target_y);
        }
        public void Turn(int target_x, int target_y)
        {
            dirext_x = dirext_y = 0;
            if (x < target_x)
                dirext_x = 1;
            if (x > target_x)
                dirext_x = -1;
            if (y < target_y)
                dirext_y = 1;
            if (y > target_y)
                dirext_y = -1;
            if ((dirext_x != 0) && (dirext_y != 0))
                if (r.Next(1000) < 500)
                    dirext_x = 0;
                else
                    dirext_y = 0;
        }
        new public void TurnArround()
        {
            Dirext_x = -1 * Dirext_x;
            Dirext_y = -1 * Dirext_y;
        }
        private void ImageTurn()
        {
            if (Dirext_x == 0)
                if (Dirext_y == 1)
                    img = hunterImg.ImageDown;
                else
                    img = hunterImg.ImageUp;
            else
                if (Dirext_x == 1)
                img = hunterImg.ImageRight;
            else
                img = hunterImg.ImageLeft;
        }
    }
}
