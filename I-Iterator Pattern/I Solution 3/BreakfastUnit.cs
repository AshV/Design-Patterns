namespace I_Solution_3
{
    public class BreakfastUnit
    {
        private MenuItem[] menuItems;
        private int size;

        public BreakfastUnit(int n)
        {
            menuItems = new MenuItem[n];
        }

        public void addItem(MenuItem menuItem)
        {
            if (size == menuItems.Length)
                System.Console.WriteLine("You cannot add any more menu items");
            else
                menuItems[size++] = menuItem;
        }

        public Iterator iterator()
        {
            return new BreakfastUnitIterator(menuItems);
        }
    }
}