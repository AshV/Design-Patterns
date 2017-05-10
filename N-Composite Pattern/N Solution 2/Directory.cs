using System.Collections.Generic;
using static System.Console;

namespace N_Solution_2
{
    public class Directory : Node
    {
        private List<Node> children;

        public Directory(string name) : this(null, name)
        {
        }

        public Directory(Directory parent, string name) : base(parent, name)
        {
            children = new List<Node>();
            if (parent != null)
                parent.add(this);
        }

        public void add(Node node)
        {
            children.Add(node);
        }

        public override void find(string pattern)
        {
            foreach (var node in children)
                node.find(pattern);
        }

        public override void traverse()
        {
            WriteLine(this);
            foreach (var node in children)
                node.traverse();
        }

        public override string ToString()
        {
            return "Directory [name=" + name + "]";
        }
    }
}