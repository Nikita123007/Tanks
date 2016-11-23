using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class PackmanImg
    {
        Image[] imageUp = new Image[] { Properties.Resources.Pacman1U,
                                        Properties.Resources.Pacman2U,
                                        Properties.Resources.Pacman3U,
                                        Properties.Resources.Pacman4U,
                                        Properties.Resources.Pacman5U};
        Image[] imageDown = new Image[] { Properties.Resources.Pacman1D,
                                          Properties.Resources.Pacman2D,
                                          Properties.Resources.Pacman3D,
                                          Properties.Resources.Pacman4D,
                                          Properties.Resources.Pacman5D};
        Image[] imageLeft = new Image[] { Properties.Resources.Pacman1L,
                                          Properties.Resources.Pacman2L,
                                          Properties.Resources.Pacman3L,
                                          Properties.Resources.Pacman4L,
                                          Properties.Resources.Pacman5L};
        Image[] imageRight = new Image[] { Properties.Resources.Pacman1R,
                                           Properties.Resources.Pacman2R,
                                           Properties.Resources.Pacman3R,
                                           Properties.Resources.Pacman4R,
                                           Properties.Resources.Pacman5R};

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
