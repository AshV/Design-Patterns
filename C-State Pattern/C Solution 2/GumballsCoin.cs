using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Solution_2
{
    public class GumballsCoin : IState
    {
        private GumballMachine gbm;
        public GumballsCoin(GumballMachine gbm)
        {
            this.gbm = gbm;
        }
        public void addGumballs(int count)
        {
            Console.WriteLine("Added gumballs");
            gbm.addCount(count);
        }

        public void insertCoin()
        {
            Console.WriteLine("Coin already inserted");
        }

        public void turnHandle()
        {
            gbm.updateState();
            if (gbm.getNumGumballs() == 0)
                gbm.setState(gbm.getState("ng_nc"));
            else
                gbm.setState(gbm.getState("g_nc"));
        }
    }
}
