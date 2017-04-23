using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Solution_3
{
    public class CoffeeRecipe : Recipe
    {
        protected override void addPowder()
        {
            Console.WriteLine("Adding coffee powder");
        }
        protected override void addIngradients()
        {
            Console.WriteLine("Add milk and sugar");
        }
    }
}
