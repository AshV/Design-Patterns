namespace H_Solution_4
{
    public class ScaleCommand : AbstractCommand
    {
        private int j;

        public ScaleCommand(Square square, int j) : base(square)
        {
            this.j = j;
        }

        public override void execute()
        {
            square.scale(j);
        }

        public override void undo()
        {
            square.scale_undo(j);
        }
    }
}