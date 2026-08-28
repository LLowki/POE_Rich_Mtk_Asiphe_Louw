namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class Position
    {
        private int x;                  //X and  Y integer variables for tile positions
        private int y;

        public Position(int x, int y)   //Position constructor
        {
            this.x = x;
            this.y = y;
        }

        public int X                    //X value property
        {
            get { return x; }
            set { x = value; }
        }

        public int Y                    //Y value property
        {
            get { return y; }
            set { y = value; }
        }
    }
}
