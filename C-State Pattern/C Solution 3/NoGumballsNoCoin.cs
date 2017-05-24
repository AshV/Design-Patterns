using static System.Console;

namespace C_Solution_3
{
    public class NoGumballsNoCoin:IState
    {
        private static NoGumballsNoCoin instance = new NoGumballsNoCoin();

        private NoGumballsNoCoin() { }

        public static NoGumballsNoCoin getInstance
        {
            get { return instance; }
        }

        public void addGumballs(GumballMachine gbm, int count)
        {
            WriteLine("Added gumballs!");
            gbm.addCount(count);
            gbm.setState(GumballsNoCoin.getInstance);
        }

        public void insertCoin(GumballMachine gbm)
        {
            WriteLine("Coin is Inserted!");
            gbm.setState(NoGumballsCoin.getInstance);
        }

        public void turnHandle(GumballMachine gbm)
        {
            WriteLine("Insert Coin");
        }
    }
}