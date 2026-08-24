using System;
using System.Text;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class Level
    {
        private Tile[,] tiles;
        private int width;
        private int height;
        private HeroTile hero;
        private ExitTile exit;
        private Random random;

        public Tile[,] Tiles
        {
            get { return tiles; }
        }

        public HeroTile Hero
        {
            get { return hero; }
        }

        public ExitTile Exit
        {
            get { return exit; }
        }

        public Level(int width, int height, HeroTile hero = null)
        {
            this.width = width;
            this.height = height;
            tiles = new Tile[width, height];
            random = new Random();

            InitialiseTiles();

            Position heroPosition = GetRandomEmptyPosition();

            if (hero == null)
            {
                this.hero = (HeroTile)CreateTile(TileType.Hero, heroPosition);
            }
            else
            {
                hero.Position = heroPosition;
                tiles[heroPosition.X, heroPosition.Y] = hero;
                this.hero = hero;
            }

            Position exitPosition = GetRandomEmptyPosition();
            exit = (ExitTile)CreateTile(TileType.Exit, exitPosition);

            this.hero.UpdateVision(this);
        }

        private enum TileType
        {
            Empty,
            Wall,
            Hero,
            Exit
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
                case TileType.Hero:
                    tile = new HeroTile(position);
                    break;
                case TileType.Exit:
                    tile = new ExitTile(position);
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

        private Position GetRandomEmptyPosition()
        {
            int x;
            int y;

            do
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            }
            while (!(tiles[x, y] is EmptyTile));

            return new Position(x, y);
        }

        public void SwapTiles(Tile firstTile, Tile secondTile)
        {
            Position firstPosition = firstTile.Position;
            Position secondPosition = secondTile.Position;

            tiles[firstPosition.X, firstPosition.Y] = secondTile;
            tiles[secondPosition.X, secondPosition.Y] = firstTile;

            firstTile.Position = secondPosition;
            secondTile.Position = firstPosition;
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
