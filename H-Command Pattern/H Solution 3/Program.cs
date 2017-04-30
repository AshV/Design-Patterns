namespace H_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[20];

            squares[0] = new Square(0, 10);
            squares[1] = new Square(1, 15);

            Invoker invoker = new Invoker();

            invoker.move(squares[0], 5, 5);
            invoker.scale(squares[0], 2);
            invoker.print(squares[0]);

            invoker.scale(squares[1], 3);
            invoker.print(squares[1]);

            invoker.undo();
            invoker.print(squares[1]);
            invoker.print(squares[0]);
        }
    }
}

// Problem: invoker class attached to specific shape called squares