using static System.Console;

namespace C_Solution_3
{
    public class GumballsNoCoin : IState
    {
        private static GumballsNoCoin instance = new GumballsNoCoin();

        public static GumballsNoCoin getInstance
        {
            get { return instance; }
        }

        public void addGumballs(GumballMachine gbm, int count)
        {
        }

        public void insertCoin(GumballMachine gbm)
        {
        }

        public void turnHandle(GumballMachine gbm)
        {
        }
    }
}