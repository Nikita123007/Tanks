using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class ProjectileImg
    {
        Image imageUp = Properties.Resources.ProjecfileU;
        Image imageDown = Properties.Resources.ProjecfileD;
        Image imageLeft = Properties.Resources.ProjecfileL;
        Image imageRight = Properties.Resources.ProjecfileR;

        public Image ImageUp
        {
            get
            {
                return imageUp;
            }
        }
        public Image ImageDown
        {
            get
            {
                return imageDown;
            }
        }
        public Image ImageLeft
        {
            get
            {
                return imageLeft;
            }
        }
        public Image ImageRight
        {
            get
            {
                return imageRight;
            }
        }
    }
}
