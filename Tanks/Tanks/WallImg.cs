using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class WallImg
    {
        Image image = Properties.Resources.Wall;

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }
    }
}
