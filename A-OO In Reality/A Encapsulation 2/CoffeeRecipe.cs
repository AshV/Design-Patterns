using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Encapsulation_2
{
    public class CoffeeRecipe : Recipe
    {
        protected override void addIngradients()
        {
            Console.WriteLine("Add Milk & Sugar");
        }

        protected override void addPowder()
        {
            Console.WriteLine("Add Coffee Powder");
        }
    }
}
