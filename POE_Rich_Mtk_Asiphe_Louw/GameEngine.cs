using System;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class GameEngine
    {
        private const int MIN_SIZE = 10;        //Minimum size that a tile row or column can be
        private const int MAX_SIZE = 20;        //Maximun size that a tile row or column can be

        private Level currentLevel;             //Level type variable to store the currents level's data
        private int numberOfLevels;             //Variable to hold the amount of levels the game will generate
        private int currentLevelNumber;
        private Random random;
        private GameState gameState = GameState.InProgress;

        public GameEngine(int numberOfLevels)
        {
            this.numberOfLevels = numberOfLevels;
            currentLevelNumber = 1;
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

            if (targetTile is ExitTile)
            {
                if (currentLevelNumber == numberOfLevels)
                {
                    gameState = GameState.Complete;
                    return false;
                }

                NextLevel();
                return true;
            }

            if (!(targetTile is EmptyTile))
            {
                return false;
            }

            currentLevel.SwapTiles(hero, targetTile);
            hero.UpdateVision(currentLevel);
            return true;
        }

        private void NextLevel()
        {
            currentLevelNumber++;
            HeroTile hero = currentLevel.Hero;

            int width = random.Next(MIN_SIZE, MAX_SIZE + 1);
            int height = random.Next(MIN_SIZE, MAX_SIZE + 1);
            currentLevel = new Level(width, height, hero);
        }

        public void TriggerMovement(Direction direction)
        {
            MoveHero(direction);
        }

        public override string ToString()
        {
            if (gameState == GameState.Complete)
            {
                return "Congratulations! You have successfully completed the game.";
            }

            return currentLevel.ToString();
        }
    }
}
