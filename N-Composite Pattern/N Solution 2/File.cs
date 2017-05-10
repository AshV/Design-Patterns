using static System.Console;

namespace N_Solution_2
{
    public class File : Node
    {
        public File(Directory parent, string name) : base(parent, name)
        {
            parent.add(this);
        }

        public override void find(string pattern)
        {
            if (name.IndexOf(pattern) != -1)
                WriteLine(this);
        }

        public override void traverse()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            return "File [name=" + name + ", parent=" + parent + "]";
        }
    }
}