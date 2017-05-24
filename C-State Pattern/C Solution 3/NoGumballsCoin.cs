using static System.Console;

namespace C_Solution_3
{
    public class NoGumballsCoin:IState
    {
        private static NoGumballsCoin instance = new NoGumballsCoin();

        public static NoGumballsCoin getInstance
        {
            get { return instance; }
        }

        public void addGumballs(GumballMachine gbm,int count) {
        }

        public void insertCoin(GumballMachine gbm)
        {
        }

        public void turnHandle(GumballMachine gbm)
        {
        }
    }
}