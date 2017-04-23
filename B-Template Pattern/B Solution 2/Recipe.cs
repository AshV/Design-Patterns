using System;

namespace B_Solution_2
{
   public abstract class Recipe
    {
        protected void boilWater()
        {
            Console.WriteLine("Boiling Water");
        }
        protected void pour()
        {
            Console.WriteLine("Pouring into Cup");
        }
    }
}
