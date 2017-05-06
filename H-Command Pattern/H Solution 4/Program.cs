﻿namespace H_Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[20];

            squares[0] = new Square(0, 10);
            squares[1] = new Square(1, 15);

            Invoker invoker = new Invoker();

            AbstractCommand command = new MoveCommand(squares[0], 5, 5);
            invoker.execute(command);
            command = new ScaleCommand(squares[0], 2);
            invoker.execute(command);
            command = new PrintCommand(squares[0]);
            invoker.execute(command);

            command = new ScaleCommand(squares[1], 3);
            invoker.execute(command);
            command = new PrintCommand(squares[1]);
            invoker.execute(command);

            invoker.undo();
            command = new PrintCommand(squares[0]);
            invoker.execute(command);
            command = new PrintCommand(squares[1]);
            invoker.execute(command);
        }
    }
}

// Problem: invoker class attached to specific shape called suqares