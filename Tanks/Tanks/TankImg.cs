using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class TankImg
    {
        Image[] imageUp = new Image[] { Properties.Resources.Tank1U,
                                        Properties.Resources.Tank2U,
                                        Properties.Resources.Tank3U,
                                        Properties.Resources.Tank4U,
                                        Properties.Resources.Tank5U};
        Image[] imageDown = new Image[] { Properties.Resources.Tank1D,
                                          Properties.Resources.Tank2D,
                                          Properties.Resources.Tank3D,
                                          Properties.Resources.Tank4D,
                                          Properties.Resources.Tank5D};
        Image[] imageLeft = new Image[] { Properties.Resources.Tank1L,
                                          Properties.Resources.Tank2L,
                                          Properties.Resources.Tank3L,
                                          Properties.Resources.Tank4L,
                                          Properties.Resources.Tank5L};
        Image[] imageRight = new Image[] { Properties.Resources.Tank1R,
                                           Properties.Resources.Tank2R,
                                           Properties.Resources.Tank3R,
                                           Properties.Resources.Tank4R,
                                           Properties.Resources.Tank5R};

        public Image[] ImageUp
        {
            get
            {
                return imageUp;
            }
        }
        public Image[] ImageDown
        {
            get
            {
                return imageDown;
            }
        }
        public Image[] ImageLeft
        {
            get
            {
                return imageLeft;
            }
        }
        public Image[] ImageRight
        {
            get
            {
                return imageRight;
            }
        }
    }
}
