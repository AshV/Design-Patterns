using System.Collections.Generic;

namespace I_Solution_3
{
    public class DinnerUnit
    {
        private List<MenuItem> menuItems;

        public DinnerUnit()
        {
            menuItems = new List<MenuItem>();
        }

        public void addItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public Iterator iterator()
        {
            return new DinnerUnitIterator(menuItems);
        }

    }
}