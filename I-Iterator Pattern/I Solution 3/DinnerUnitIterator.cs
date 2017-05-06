using System.Collections.Generic;

namespace I_Solution_3
{
    public class DinnerUnitIterator : Iterator
    {
        private List<MenuItem> menuItems;
        private int current;

        public DinnerUnitIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool hasNext()
        {
            return current < menuItems.Count;
        }

        public MenuItem next()
        {
            return menuItems[current++];
        }
    }
}