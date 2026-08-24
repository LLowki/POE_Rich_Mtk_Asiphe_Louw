namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class ExitTile : Tile
    {
        public ExitTile(Position position) : base(position)
        {
        }

        public override char Display
        {
            get { return '\u2591'; }
        }
    }
}
