namespace K_Solution_1
{
    public class Account
    {
        private int id;
        private string name;
        private string type;
        private float balance;

        public Account(int id, string name, string type, float balance)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.balance = balance;
        }

        public override string ToString()
        {
            return "Account [id=" + id + ", name=" + name + ", type=" + type + ", balance=" + balance + "]";
        }
    }
}