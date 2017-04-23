using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Encapsulation_2
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
