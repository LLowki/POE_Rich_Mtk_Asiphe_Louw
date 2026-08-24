namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class EmptyTile : Tile
    {
        public EmptyTile(Position position) : base(position)
        {
        }

        public override char Display
        {
            get { return '.'; }
        }
    }
}
