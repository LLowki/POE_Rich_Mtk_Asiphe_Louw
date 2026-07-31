using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    abstract class Tile
    {
        private static Position tilePosition = new Position(y, x);
        private static int x;
        private static int y;

        public Tile(Position startPosition)
        {
            tilePosition = startPosition;
        }

        public int xTile
        {
            get
            {
                return tilePosition.xPosition;
            }
        }

        public int yTile
        {
            get
            {
                return tilePosition.yPosition;
            }
        }



        public abstract char Display
        {
            get;
        }
    }
}
