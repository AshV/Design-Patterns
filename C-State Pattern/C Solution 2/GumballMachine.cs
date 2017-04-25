using System;

namespace C_Solution_2
{
    public class GumballMachine
    {
        private int ngumballs;
        private float money;
        private IState state;

        private NoGumballsNoCoin ng_nc;
        private NoGumballsCoin ng_c;
        private GumballsNoCoin g_nc;
        private GumballsCoin g_c;

        public IState getState(string id)
        {
            if (id.Equals("ng_nc"))
                return ng_nc;
            else if (id.Equals("ng_c"))
                return ng_c;
            else if (id.Equals("g_nc"))
                return g_nc;
            else
                return g_c;
        }

        public GumballMachine()
        {
            ngumballs = 0;
            money = 0.0f;
            ng_nc = new NoGumballsNoCoin(this);
            ng_c = new NoGumballsCoin(this);
            g_nc = new GumballsNoCoin(this);
            g_c = new GumballsCoin(this);
            state = ng_nc;
        }

        // Reuse the default constructor logic with :this()
        public GumballMachine(int count) : this()
        {
            ngumballs = count;
            money = 0.0f;
            state = g_nc;
        }

        public void addGumballs(int count)
        {
            state.addGumballs(count);
        }

        public void insertCoin()
        {
            state.insertCoin();
        }

        public void turnHandle()
        {
            state.turnHandle();
        }


        public override String ToString()
        {
            return "GumballMachine [ngumballs=" + ngumballs + ", money=" + money
                    + ", state=" + state + "]";
        }

        public void addCount(int count)
        {
            ngumballs += count;
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public void updateState()
        {
            ngumballs -= 1;
            money += 1;
        }

        public int getNumGumballs()
        {
            return ngumballs;
        }
    }
}
