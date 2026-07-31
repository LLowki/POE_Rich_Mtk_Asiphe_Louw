using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class GameEngine
    {
        private Level currentLevel;
        private int amountLevel;
        private Random randomRoll = new Random();
        private int MIN_SIZE = 10;
        private int MAX_SIZE = 20;

        public GameEngine(int newAmount)
        {
            amountLevel = newAmount;
            int yRoll = randomRoll.Next(MIN_SIZE, MAX_SIZE);
            int xRoll = randomRoll.Next(MIN_SIZE, MAX_SIZE);

            currentLevel = new Level(yRoll, xRoll);
        }

        public override string ToString()
        {
            return currentLevel.ToString();
        }
    }
}
