namespace H_Solution_3
{
    public class Invoker
    {
        private AbstractCommand lastCommand;

        public void move(Square square, int j, int k)
        {
            lastCommand = new MoveCommand(square, j, k);
            square.move(j, k);
        }

        public void scale(Square square, int j)
        {
            lastCommand = new ScaleCommand(square, j);
            square.scale(j);
        }

        public void print(Square square)
        {
            System.Console.WriteLine(square.ToString());
        }

        public void undo()
        {
            if (lastCommand == null)
            {
                System.Console.WriteLine("No Command Exist for Undo");
                return;
            }
            lastCommand.undo();
            lastCommand = null;
        }
    }
}