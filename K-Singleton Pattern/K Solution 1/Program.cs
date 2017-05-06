using System.Threading;

namespace K_Solution_1
{
    class Program
    {
        public static void test1()
        {
            Bank bank1 = Bank.getInstance();
            bank1.addAccount(new Account(1, "abc", "savings", 10000));
            bank1.addAccount(new Account(2, "def", "current", 15000));
            bank1.display();

            Bank bank2 = Bank.getInstance();
            bank2.display();
        }

        public static void test2()
        {
            var dummy = new Dummy();
            Thread t1 = new Thread(new ThreadStart(dummy.run));
            Thread t2 = new Thread(new ThreadStart(dummy.run));
            t1.Start();
            t2.Start();
        }

        static void Main(string[] args)
        {
            var dummy = new Dummy();
            dummy.run();
            test2();
        }
    }

    class Dummy
    {
        public void run()
        {
            Bank.getInstance().addAccount(new Account(1, "abc", "savings", 10000));
            Bank.getInstance().addAccount(new Account(2, "def", "current", 15000));
            Bank.getInstance().display();
        }
    }
}
