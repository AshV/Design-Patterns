namespace O_Solution_1
{
    public abstract class AbstractHandler
    {
        private string name;
        private string role;

        public AbstractHandler(string name, string role)
        {
            this.name = name;
            this.role = role;
        }

        public override string ToString()
        {
            return "AbstractRole [name=" + name + ", role=" + role + "]";
        }
    }
}