namespace H_Solution_2
{
    public class Invoker
    {
        public AbstractCommand lastCommand;

        public void move(Square square, int j, int k)
        {
            lastCommand = new MoveCommand("move", square, j, k);
            square.move(j, k);
        }

        public void scale(Square square, int j)
        {
            lastCommand = new ScaleCommand("scale", square, j);
            square.scale(j);
        }

        public void print(Square square)
        {
            System.Console.WriteLine(square.toString());
            System.Console.WriteLine();
        }

        public void undo()
        {
            if (lastCommand == null)
            {
                System.Console.WriteLine("No command exist for undo");
                return;
            }

            if (lastCommand.getCommand().Equals("move"))
            {
                MoveCommand move_cmd = (MoveCommand)lastCommand;
                move_cmd.getSquare().move_undo(move_cmd.getJ(), move_cmd.getK());
            }
            else if (lastCommand.getCommand().Equals("scale"))
            {
                ScaleCommand scale_cmd = (ScaleCommand)lastCommand;
                scale_cmd.getSquare().scale_undo(scale_cmd.getJ());
            }
            else
            {
                System.Console.WriteLine("Invalid Command");
            }
            lastCommand = null;
        }
    }
}
