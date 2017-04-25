using System;

namespace C_Solution_2
{
    public class NoGumballsNoCoin : IState
    {
        private GumballMachine gbm;
        public NoGumballsNoCoin(GumballMachine gbm)
        {
            this.gbm = gbm;
        }

        public void addGumballs(int count)
        {
            Console.WriteLine("Added Gumballs");
            gbm.addCount(count);
            gbm.setState(gbm.getState("g_nc"));
        }

        public void insertCoin()
        {
            Console.WriteLine("Coin is Inserted");
            gbm.setState(gbm.getState("ng_c"));
        }

        public void turnHandle()
        {
            Console.WriteLine("Insert Coin");
        }
    }
}
