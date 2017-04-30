namespace H_Solution_2
{
    public abstract class AbstractCommand
    {
        private string command;
        private Square square;

        public AbstractCommand(string command, Square square)
        {
            this.command = command;
            this.square = square;
        }

        public string getCommand()
        {
            return command;
        }

        public Square getSquare()
        {
            return square;
        }
    }
}