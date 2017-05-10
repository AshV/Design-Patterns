namespace N_Solution_2
{
    public abstract class Node
    {
        protected string name;
        protected Directory parent;

        public Node(Directory parent, string name)
        {
            this.name = name;
            this.parent = parent;
        }

        public abstract void traverse();
        public abstract void find(string pattern);
    }
}