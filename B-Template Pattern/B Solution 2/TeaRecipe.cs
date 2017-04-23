using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Solution_2
{
    public class TeaRecipe : Recipe
    {
        private void addTeaPowder()
        {
            Console.WriteLine("Adding tea powder");
        }
        private void addIngradients()
        {
            Console.WriteLine("Add lemon");
        }

        public void makeTea()
        {
            boilWater();
            addTeaPowder();
            pour();
            addIngradients();
        }
    }
}
