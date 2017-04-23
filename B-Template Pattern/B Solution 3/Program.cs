using System;

namespace B_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaRecipe tr1 = new TeaRecipe();
            tr1.makeRecipe();

            Console.WriteLine();

            CoffeeRecipe cr1 = new CoffeeRecipe();
            cr1.makeRecipe();
        }
    }
}
