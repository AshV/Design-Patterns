using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Solution_1
{
    public class CoffeeRecipe
    {
        private void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void addCoffeePowder()
        {
            Console.WriteLine("Adding coffee powder");
        }
        private void pour()
        {
            Console.WriteLine("Pouring into cup");
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
