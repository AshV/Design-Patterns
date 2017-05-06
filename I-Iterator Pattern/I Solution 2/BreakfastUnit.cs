namespace I_Solution_2
{
    public class BreakfastUnit : Iterator
    {
        private MenuItem[] menuItems;
        private int size;
        private int current;

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

        public bool hasNext()
        {
            return current < menuItems.Length;
        }

        public MenuItem next()
        {
            return menuItems[current++];
        }

        public void reset()
        {
            current = 0;
        }
    }
}