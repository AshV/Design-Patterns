using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Solution_2
{
    public class GumballsNoCoin : IState
    {
        private GumballMachine gbm;
        public GumballsNoCoin(GumballMachine gbm)
        {
            this.gbm = gbm;
        }
        public void addGumballs(int count)
        {
            throw new NotImplementedException();
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
