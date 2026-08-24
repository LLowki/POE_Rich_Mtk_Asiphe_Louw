using System;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class GameEngine
    {
        private const int MIN_SIZE = 10;
        private const int MAX_SIZE = 20;

        private Level currentLevel;
        private int numberOfLevels;
        private Random random;

        public GameEngine(int numberOfLevels)
        {
            this.numberOfLevels = numberOfLevels;
            random = new Random();

            int width = random.Next(MIN_SIZE, MAX_SIZE + 1);
            int height = random.Next(MIN_SIZE, MAX_SIZE + 1);
            currentLevel = new Level(width, height);
        }

        private bool MoveHero(Direction direction)
        {
            if (direction == Direction.None)
            {
                return false;
            }

            HeroTile hero = currentLevel.Hero;
            Tile targetTile = hero.Vision[(int)direction];

            if (!(targetTile is EmptyTile))
            {
                return false;
            }

            currentLevel.SwapTiles(hero, targetTile);
            hero.UpdateVision(currentLevel);
            return true;
        }

        public void TriggerMovement(Direction direction)
        {
            MoveHero(direction);
        }

        public override string ToString()
        {
            return currentLevel.ToString();
        }
    }
}
