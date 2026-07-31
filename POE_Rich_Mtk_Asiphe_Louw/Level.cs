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

        public Level(int newWidth, int newHeight)
        {
            widthLayout = newWidth;
            heightLayout = newHeight;

            levelLayout = new Tile[heightLayout, widthLayout];
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
            int newX;
            int newY;

            switch (newType)
            {
                case TileType.Empty:
                    Tile newTile = new EmptyTile(newPosition);
                    newX = newPosition.xPosition;
                    newY = newPosition.yPosition;
                    levelLayout[newY, newX] = newTile;
                    sentTile = newTile;
                    break;
                case TileType.Temp:
                    break;
            }

            return sentTile;
        }

        public static void InitializeTiles()
        {
            int i = 0;
            int o = 0;
            Position intitialPosition = new Position(i, o);

            while (o <= heightLayout)
            {
                if (i <= widthLayout)
                {
                    CreateTile(TileType.Empty, intitialPosition);
                    i++;
                }
                else if (o <= heightLayout)
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
