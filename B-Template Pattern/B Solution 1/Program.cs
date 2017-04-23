using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaRecipe tr1 = new TeaRecipe();
            tr1.makeTea();

            Console.WriteLine();

            CoffeeRecipe cr1 = new CoffeeRecipe();
            cr1.makeCoffee();
        }
    }
}

/* Issues:
      1) code redundancy

*/