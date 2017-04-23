using System;

namespace B_Solution_4
{
    public abstract class Recipe
    {
        private bool needIngradients;

        public Recipe(bool needIngradients)
        {
            this.needIngradients = needIngradients;
        }

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
            if (needIngradients)
                addIngradients();
        }
    }
}
