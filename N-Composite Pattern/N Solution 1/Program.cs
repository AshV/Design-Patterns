using static System.Console;

namespace N_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory root = new Directory("/");
            Directory home = new Directory(root, "/home");
            Directory bin = new Directory(root, "/bin");

            File file1 = new File(home, "file1.txt");
            File file2 = new File(bin, "file2.bin");
            Directory user1 = new Directory(home, "user1");

            WriteLine("Traverse-" + root.getName());
            root.traverse();
            WriteLine("Traverse-" + home.getName());
            home.traverse();
            WriteLine("Traverse-" + bin.getName());
            bin.traverse();

            WriteLine("find-" + root.getName());
            root.find("file1");
            WriteLine("find1-" + bin.getName());
            bin.find("file1");
        }
    }
}