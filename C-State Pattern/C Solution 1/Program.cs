using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine m1 = new GumballMachine();
            m1.turnHandle();
            Console.WriteLine(m1);
            m1.addGumballs(10);
            Console.WriteLine(m1);
            m1.turnHandle();
            Console.WriteLine(m1);
            m1.insertCoin();
            Console.WriteLine(m1);
            m1.turnHandle();
            Console.WriteLine(m1);
        }
    }
}
