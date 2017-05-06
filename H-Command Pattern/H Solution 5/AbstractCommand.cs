namespace H_Solution_5
{
    public abstract class AbstractCommand
    {
        protected Square square;

        public AbstractCommand(Square square)
        {
            this.square = square;
        }

        public Square getSquare()
        {
            return square;
        }

        public abstract void undo();

        public void redo()
        {
            execute();
        }

        public abstract void execute();

        public bool undoable()
        {
            return true;
        }
    }
}