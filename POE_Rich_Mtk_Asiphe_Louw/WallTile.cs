namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class WallTile : Tile
    {
        public WallTile(Position position) : base(position)
        {
        }

        public override char Display
        {
            get { return '\u2588'; }
        }
    }
}
