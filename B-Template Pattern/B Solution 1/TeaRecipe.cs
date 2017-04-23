using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Solution_1
{
    public class TeaRecipe
    {
        private void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void addTeaPowder()
        {
            Console.WriteLine("Adding tea powder");
        }
        private void pour()
        {
            Console.WriteLine("Pouring into cup");
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
