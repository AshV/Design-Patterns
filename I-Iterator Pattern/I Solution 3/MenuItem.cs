﻿namespace I_Solution_3
{
    public class MenuItem
    {
        private string name;
        private float price;
        private int qty;

        public MenuItem(string name, float price, int qty)
        {
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        public new string ToString()
        {
            return "MenuItem [name=" + name + ", price=" + price + ", qty=" + qty + "]";
        }
    }
}