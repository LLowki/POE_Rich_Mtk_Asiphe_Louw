namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal abstract class Tile
    {
        private Position position;

        protected Tile(Position position)
        {
            this.position = position;
        }

        public int X
        {
            get { return position.X; }
        }

        public int Y
        {
            get { return position.Y; }
        }

        public abstract char Display
        {
            get;
        }
    }
}
