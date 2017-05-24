using static System.Console;

namespace C_Solution_3
{
    public class GumballsCoin : IState
    {
        private static GumballsCoin instance = new GumballsCoin();

        private GumballsCoin() { }

        public static GumballsCoin getInstance
        {
            get { return instance; }
        }

        public void addGumballs(GumballMachine gbm, int count)
        {
            WriteLine("Added gumballs!");
            gbm.addCount(count);
        }

        public void insertCoin(GumballMachine gbm)
        {
            WriteLine("Coin already inserted!");
        }

        public void turnHandle(GumballMachine gbm)
        {
            gbm.updateState();
            if (gbm.getNumGumballs() == 0)
                gbm.setState(NoGumballsNoCoin.getInstance);
            else
                gbm.setState(GumballsNoCoin.getInstance);
        }
    }
}