namespace I_Solution_1
{
    public class MenuItem
    {
        public string name;
        public float price;
        private int qty;

        public MenuItem(string name, float price, int qty) : base()
        {
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        public override string ToString()
        {
            return "MenuItem [name=" + name + ", price=" + price + ", qty=" + qty + "]";
        }
    }

}