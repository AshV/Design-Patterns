using System;

namespace B_Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaRecipe tr1 = new TeaRecipe(true);
            tr1.makeRecipe();
            Console.WriteLine();
            TeaRecipe tr2 = new TeaRecipe(false);
            tr2.makeRecipe();
            Console.WriteLine();
            CoffeeRecipe cr1 = new CoffeeRecipe(false);
            cr1.makeRecipe();
        }
    }
}
