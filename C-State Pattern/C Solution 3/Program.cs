using static System.Console;

namespace C_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine m1 = new GumballMachine();
            m1.turnHandle();
            WriteLine(m1);
            m1.addGumballs(10);
            WriteLine(m1);
            m1.turnHandle();
            WriteLine(m1);
            m1.insertCoin();
            WriteLine(m1);
            m1.turnHandle();
            WriteLine(m1);
        }
    }
}