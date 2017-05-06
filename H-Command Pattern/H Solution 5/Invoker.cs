using System.Collections.Generic;

namespace H_Solution_5
{
    public class Invoker
    {
        private Stack<AbstractCommand> undo_commands;
        private Stack<AbstractCommand> redo_commands;

        public Invoker()
        {
            undo_commands = new Stack<AbstractCommand>();
            redo_commands = new Stack<AbstractCommand>();
        }

        public void execute(AbstractCommand command)
        {
            if (command.undoable())
                undo_commands.Push(command);
            command.execute();
        }

        public void undo()
        {
            if (undo_commands.Count == 0)
            {
                System.Console.WriteLine("No command exist for Undo");
                return;
            }

            AbstractCommand cmd = undo_commands.Pop();
            redo_commands.Push(cmd);
            cmd.undo();
        }

        public void redo()
        {
            if (redo_commands.Count == 0)
            {
                System.Console.WriteLine("No command exist for redo");
                return;
            }

            AbstractCommand cmd = redo_commands.Pop();
            undo_commands.Push(cmd);
            cmd.redo();
        }

        public void flush()
        {
            undo_commands.Clear();
            redo_commands.Clear();
        }
    }
}