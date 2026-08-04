using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class Position
    {
        private static int xCoord;
        private static int yCoord;

        public Position(int newY, int newX)
        {
            xCoord = newX;
            yCoord = newY;
        }

        public int xPosition
        {
            get
            {
                return xCoord;
            }

            set
            {
                xCoord = value;
            }
        }

        public int yPosition
        {
            get
            {
                return yCoord;
            }

            set
            {
                yCoord = value;
            }
        }
    }
}
