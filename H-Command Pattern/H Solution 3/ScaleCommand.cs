namespace H_Solution_3
{
    public class ScaleCommand : AbstractCommand
    {
        private int j;

        public ScaleCommand(Square square, int j) : base(square)
        {
            this.j = j;
        }

        public override void undo()
        {
            square.scale_undo(j);
        }
    }
}