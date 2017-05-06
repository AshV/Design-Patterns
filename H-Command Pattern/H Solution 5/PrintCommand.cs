namespace H_Solution_5
{
    public class PrintCommand : AbstractCommand
    {
        public PrintCommand(Square square) : base(square)
        {
        }

        public override void execute()
        {
            System.Console.WriteLine(square.ToString());
        }

        public override void undo()
        {
        }

        public new bool undoable()
        {
            return false;
        }
    }
}