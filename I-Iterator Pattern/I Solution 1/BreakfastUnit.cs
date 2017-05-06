namespace I_Solution_1
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
                System.Console.WriteLine("You can't add any more menu items");
            else
                menuItems[size++] = menuItem;
        }

        public MenuItem[] getMenuItems()
        {
            return menuItems;
        }
    }
}