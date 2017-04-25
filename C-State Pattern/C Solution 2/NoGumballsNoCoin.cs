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
           
        }

        public void insertCoin()
        {
            throw new NotImplementedException();
        }

        public void turnHandle()
        {
            throw new NotImplementedException();
        }
    }
}
