namespace H_Solution_4
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
            // throw new NotImplementedException();
        }

        public bool undoable()
        {
            return false;
        }
    }
}
