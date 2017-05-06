namespace I_Solution_3
{
    class BreakfastUnitIterator : Iterator
    {
        private MenuItem[] menuItems;
        private int current;

        public BreakfastUnitIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool hasNext()
        {
            return current < menuItems.Length;
        }

        public MenuItem next()
        {
            return menuItems[current++];
        }
    }
}