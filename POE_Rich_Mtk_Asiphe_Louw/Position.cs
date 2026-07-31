using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class Position
    {
        private static int x;
        private static int y;

        public Position(int newY, int newX)
        {
            x = newX;
            y = newY;
        }

        public int xPosition
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int yPosition
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
