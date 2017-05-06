using System;
using System.Collections.Generic;

namespace I_Solution_2
{
    public class DinnerUnit : Iterator
    {
        private List<MenuItem> menuItems;
        private int current;

        public DinnerUnit()
        {
            menuItems = new List<MenuItem>();
            current = 0;
        }

        public void addItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public bool hasNext()
        {
            return current < menuItems.Count;
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