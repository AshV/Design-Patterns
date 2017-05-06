using System.Collections.Generic;

namespace I_Solution_1
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

        public List<MenuItem> getMenuItems()
        {
            return menuItems;
        }
    }
}
