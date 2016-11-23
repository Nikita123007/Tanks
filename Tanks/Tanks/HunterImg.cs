using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class HunterImg
    {
        Image[] imageUp = new Image[] { Properties.Resources.Hunter1U,
                                        Properties.Resources.Hunter2U,
                                        Properties.Resources.Hunter3U,
                                        Properties.Resources.Hunter4U,
                                        Properties.Resources.Hunter5U};
        Image[] imageDown = new Image[] { Properties.Resources.Hunter1D,
                                          Properties.Resources.Hunter2D,
                                          Properties.Resources.Hunter3D,
                                          Properties.Resources.Hunter4D,
                                          Properties.Resources.Hunter5D};
        Image[] imageLeft = new Image[] { Properties.Resources.Hunter1L,
                                          Properties.Resources.Hunter2L,
                                          Properties.Resources.Hunter3L,
                                          Properties.Resources.Hunter4L,
                                          Properties.Resources.Hunter5L};
        Image[] imageRight = new Image[] { Properties.Resources.Hunter1R,
                                           Properties.Resources.Hunter2R,
                                           Properties.Resources.Hunter3R,
                                           Properties.Resources.Hunter4R,
                                           Properties.Resources.Hunter5R};

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
