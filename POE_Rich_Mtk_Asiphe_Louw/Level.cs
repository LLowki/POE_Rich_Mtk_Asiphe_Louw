using System;
using System.Text;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class Level
    {
        private Tile[,] tiles;
        private int width;
        private int height;

        public Level(int width, int height)
        {
            this.width = width;
            this.height = height;
            tiles = new Tile[width, height];

            InitialiseTiles();
        }

        private enum TileType
        {
            Empty,
            Wall
        }

        private Tile CreateTile(TileType tileType, Position position)
        {
            Tile tile;

            switch (tileType)
            {
                case TileType.Empty:
                    tile = new EmptyTile(position);
                    break;
                case TileType.Wall:
                    tile = new WallTile(position);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tileType));
            }

            tiles[position.X, position.Y] = tile;
            return tile;
        }

        private void InitialiseTiles()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bool isBoundary = x == 0 || x == width - 1 || y == 0 || y == height - 1;
                    TileType tileType = isBoundary ? TileType.Wall : TileType.Empty;
                    CreateTile(tileType, new Position(x, y));
                }
            }
        }

        public override string ToString()
        {
            StringBuilder levelDisplay = new StringBuilder();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    levelDisplay.Append(tiles[x, y].Display);
                }

                levelDisplay.Append('\n');
            }

            return levelDisplay.ToString();
        }
    }
}
