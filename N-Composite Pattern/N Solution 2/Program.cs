using static System.Console;

namespace N_Solution_2
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
            Directory user1 = new Directory(home, "/user1");

            root.traverse();
            WriteLine();
            home.traverse();
            WriteLine();
            bin.traverse();
            WriteLine();
            root.find("file1");
            WriteLine();
            bin.find("file1");
        }
    }
}