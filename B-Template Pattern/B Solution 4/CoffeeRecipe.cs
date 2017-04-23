using System;

namespace B_Solution_4
{
    public class CoffeeRecipe : Recipe
    {
        public CoffeeRecipe(bool needIngradients) :
            base(needIngradients)
        {
        }

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
