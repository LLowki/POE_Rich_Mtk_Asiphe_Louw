namespace POE_Rich_Mtk_Asiphe_Louw
{
    internal class EmptyTile : Tile
    {
        public EmptyTile(Position position) : base(position)    //Empty tile class extened from parent tile class
        {
        }

        public override char Display                            //Property to associatee Empty tile class with the assigned char variable
        {
            get { return '.'; }
        }
    }
}
