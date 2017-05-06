namespace H_Solution_4
{
    public class Invoker
    {
        private AbstractCommand lastCommand;

        public void execute(AbstractCommand command)
        {
            if (command.undoable())
                lastCommand = command;
            command.execute();
        }

        public void undo()
        {
            if (lastCommand == null)
            {
                System.Console.WriteLine("No command exist for undo");
                return;
            }
            lastCommand.undo();
            lastCommand = null;
        }
    }
}
