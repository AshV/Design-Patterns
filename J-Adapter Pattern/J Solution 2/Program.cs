using System;
using System.Collections.Generic;
using static System.Console;

namespace J_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack stack = new LinkedStack();
            Random r = new Random();
            for (int i = 1; i <= 10; i++)
            {
                stack.push(r.Next(100) + 1);
            }

            IEnumerator<int> iterator = stack.iterator();
            while (iterator.MoveNext())
                WriteLine(iterator.Current);
            WriteLine("\n" + stack.size() + "\n");
            WriteLine(stack.pop());
            WriteLine("\n" + stack.size() + "\n");

            iterator = stack.iterator();
            while (iterator.MoveNext())
                WriteLine(iterator.Current);
        }
    }
}