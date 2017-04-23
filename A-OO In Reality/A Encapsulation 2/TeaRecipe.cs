using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Encapsulation_2
{
    public class TeaRecipe : Recipe
    {
        protected override void addIngradients()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void addPowder()
        {
            Console.WriteLine("Adding Tea Powder");
        }
    }
}
