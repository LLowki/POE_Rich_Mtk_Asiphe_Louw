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
        private static int widthLayout;
        private static int heightLayout;

        public Level(int newHeight, int newWidth)
        {
            widthLayout = newWidth;
            heightLayout = newHeight;

            Tile[,] levelLayout = new Tile[newHeight, newWidth];
            InitializeTiles();
        }

        public enum TileType
        {
            Empty,
            Temp
        }

        private static Tile CreateTile(TileType newType, Position newPosition)
        {
            Tile sentTile = new EmptyTile(newPosition);

            switch (newType)
            {
                case TileType.Empty:
                    sentTile = new EmptyTile(newPosition);
                    levelLayout[newPosition.yPosition, newPosition.xPosition] = sentTile;
                    break;
            }

            return sentTile;
        }

        public static void InitializeTiles()
        {
            int i = 0;
            int o = 0;
            TileType initialTile = TileType.Empty;
            Position intitialPosition = new Position(o, i);

            while (o <= heightLayout)
            {
                if (i <= widthLayout)
                {
                    CreateTile(initialTile, intitialPosition);
                    i++;
                }
                else if (i > widthLayout)
                {
                    i = 0;
                    o++;
                }
            }
        }

        public override string ToString()
        {
            int i = 0;
            int o = 0;
            string writtenLayout = "";

            while (o <= heightLayout)
            {
                if (i <= widthLayout)
                {
                    writtenLayout = writtenLayout + levelLayout[o, i].Display;
                    i++;
                }
                else if (i > widthLayout)
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
