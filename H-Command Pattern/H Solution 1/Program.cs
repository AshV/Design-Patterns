using System;

namespace H_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[20];

            squares[0] = new Square(0, 10);
            squares[1] = new Square(1, 15);

            squares[0].move(5, 5);
            squares[0].scale(2);
            Console.WriteLine(squares[0].toString());

            squares[1].scale(3);
            Console.WriteLine(squares[1].toString());
        }
    }
}
