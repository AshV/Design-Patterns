using System.Collections.Generic;
using static System.Console;

namespace N_Solution_1
{
    public class Directory
    {
        private string name;
        private Directory parent;
        private List<File> files;
        public List<Directory> directories;

        public Directory(string name) : this(null, name)
        {
        }

        public Directory(Directory parent, string name)
        {
            this.name = name;
            this.parent = parent;
            files = new List<File>();
            directories = new List<Directory>();
            if (parent != null)
                parent.add(this);
        }

        public void add(File file)
        {
            files.Add(file);
        }

        public void add(Directory directory)
        {
            directories.Add(directory);
        }

        public void traverse()
        {
            foreach (var file in files)
                WriteLine(file);
            foreach (var dir in directories)
            {
                WriteLine(dir);
                dir.traverse();
            }
        }

        public override string ToString()
        {
            return "Directory [name=" + name + "]";
        }

        public void find(string pattern)
        {
            foreach (var file in files)
            {
                if (file.getName().IndexOf(pattern) != 1)
                    WriteLine(file);
            }
            foreach (var dir in directories)
            {
                dir.find(pattern);
            }
        }

        public string getName()
        {
            return name;
        }
    }
}