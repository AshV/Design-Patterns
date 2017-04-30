namespace H_Solution_2
{
    public class MoveCommand : AbstractCommand
    {
        private int j;
        private int k;

        public MoveCommand(string command, Square square, int j, int k) : base(command, square)
        {
            this.j = j;
            this.k = k;
        }

        public int getJ()
        {
            return j;
        }
        public int getK()
        {
            return k;
        }
    }
}