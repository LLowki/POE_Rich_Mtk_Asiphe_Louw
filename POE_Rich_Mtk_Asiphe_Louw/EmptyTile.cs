using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class EmptyTile : Tile
    {
        public void emptyConstructor(Position startPosition)
        {
            tileConstructor(startPosition);
        }

        public override char Display
        {
            get { return '.'; }
        }
    }
}
