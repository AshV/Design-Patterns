using System;

namespace B_Solution_4
{
    public class TeaRecipe : Recipe
    {
        public TeaRecipe(bool needIngradients) : base(needIngradients)
        {
        }

        protected override void addPowder()
        {
            Console.WriteLine("Adding tea powder");
        }
        protected override void addIngradients()
        {
            Console.WriteLine("Add lemon");
        }
    }
}
