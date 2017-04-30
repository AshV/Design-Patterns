namespace H_Solution_3
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
    }
}