namespace I_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random r = new System.Random();

            DinnerUnit dinnerUnit = new DinnerUnit();
            for (int i = 1; i <= 10; i++)
            {
                string name = "DinnerItem" + i;
                float price = 50 + i * 5;
                int qty = r.Next(5) + 1;
                dinnerUnit.addItem(new MenuItem(name, price, qty));
            }

            BreakfastUnit breakfastUnit = new BreakfastUnit(5);
            for (int i = 1; i <= 5; i++)
            {
                string name = "BreakfastItem" + 1;
                float price = 30 + i * 5;
                int qty = r.Next(3) + 1;
                breakfastUnit.addItem(new MenuItem(name, price, qty));
            }

            //Go through all the menu items
            System.Collections.Generic.List<MenuItem> dinnerItems = dinnerUnit.getMenuItems();
            for (int i = 0; i < dinnerItems.Count; i++)
            {
                System.Console.WriteLine(dinnerItems[i]);
            }

            MenuItem[] breakfastItems = breakfastUnit.getMenuItems();
            for (int i = 0; i < breakfastItems.Length; i++)
            {
                System.Console.WriteLine(breakfastItems[i]);
            }
        }
    }
}