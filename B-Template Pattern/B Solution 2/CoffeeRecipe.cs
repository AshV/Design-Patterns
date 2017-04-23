using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Solution_2
{
    public class CoffeeRecipe : Recipe
    {
        private void addCoffeePowder()
        {
            Console.WriteLine("Adding coffee powder");
        }
        private void addIngradients()
        {
            Console.WriteLine("Add milk and sugar");
        }
        public void makeCoffee()
        {
            boilWater();
            addCoffeePowder();
            pour();
            addIngradients();
        }
    }
}
