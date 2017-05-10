namespace N_Solution_1
{
    public class File
    {
        private string name;
        private Directory parent;

        public File(Directory parent, string name)
        {
            this.name = name;
            this.parent = parent;
            parent.add(this);
        }

        public override string ToString()
        {
            return "File [name=" + name + ", parent=" + parent + "]";
        }

        public string getName()
        {
            return name;
        }

        // public string getAbsolutePath() {  }
    }
}