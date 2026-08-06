using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class Level
    {
        private static Tile[,] levelLayout;
        private static int widthLayout = 0;
        private static int heightLayout = 0;

        public Level(int newHeight, int newWidth)
        {
            widthLayout = newWidth;
            heightLayout = newHeight; levelLayout = new Tile[heightLayout, widthLayout];

            InitializeTiles();
        }

        public enum TileType
        {
            Empty
        }

        private static Tile CreateTile(TileType newType, Position newPosition)
        {
            Tile sentTile = new EmptyTile(newPosition);
            Tile newTile = new EmptyTile(newPosition);

            switch (newType)
            {
                case TileType.Empty:
                    sentTile = newTile;
                    break;
            }


            return sentTile;
        }

        public static void InitializeTiles()
        {
            TileType initialTile = TileType.Empty;

            for (int y = 0; y < heightLayout; y++)
            {
                for (int x = 0; x < widthLayout; x++)
                {
                    Position intitialPosition = new Position(y, x);
                    levelLayout[y, x] = CreateTile(initialTile, intitialPosition);
                }
            }
        }

        public override string ToString()
        {
            int i = 0;
            int o = 0;
            string writtenLayout = "";

            while (o < heightLayout)
            {
                if (i < widthLayout)
                {
                    writtenLayout = writtenLayout + levelLayout[o, i].Display;
                    i++;
                }
                else if (i >= widthLayout)
                {
                    writtenLayout = writtenLayout + "\n";
                    i = 0;
                    o++;
                }
            }
            return writtenLayout;
        }
    }
}
