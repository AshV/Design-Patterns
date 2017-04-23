using System;

namespace B_Solution_3
{
  public abstract  class Recipe
    {
        protected void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void pour()
        {
            Console.WriteLine("Pouring into cup");
        }
        protected abstract void addPowder();
        protected abstract void addIngradients();
        public void makeRecipe()
        {
            boilWater();
            addPowder();
            pour();
            addIngradients();
        }
    }
}
