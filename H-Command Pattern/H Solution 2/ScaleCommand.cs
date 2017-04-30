namespace H_Solution_2
{
    public class ScaleCommand : AbstractCommand
    {
        private int j;
        public ScaleCommand(string command, Square square, int j) : base(command, square)
        {
            this.j = j;
        }

        public int getJ()
        {
            return j;
        }
    }
}