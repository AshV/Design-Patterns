using System;

namespace A_Encapsulation_2
{
    //encapsulation at method impletation
    public abstract class Recipe
    {
        protected void boilWater()
        {
            Console.WriteLine("Boiling Water");
        }
        protected void pour()
        {
            Console.WriteLine("Pouring into cup");
        }

        //encapsulate the method implementations that coud vary among child objects
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
