using System;

namespace C_Solution_1
{
    public class GumballMachine
    {
        enum internal_state
        {
            NO_GUMBALLS_NO_COIN,
            NO_GUMBALLS_COIN,
            GUMBALLS_COIN,
            GUMBALLS_NO_COIN
        }

        private int ngumballs;
        private float money;
        private internal_state state;

        public GumballMachine()
        {
            ngumballs = 0;
            money = 0.0f;
            state = internal_state.NO_GUMBALLS_NO_COIN;
        }

        public GumballMachine(int count)
        {
            ngumballs = count;
            money = 0.0f;
            state = internal_state.GUMBALLS_NO_COIN;
        }

        public void addGumballs(int count)
        {
            ngumballs += count;
            Console.WriteLine("Added " + ngumballs);
            if (state == internal_state.NO_GUMBALLS_NO_COIN)
                state = internal_state.GUMBALLS_NO_COIN;
            else if (state == internal_state.NO_GUMBALLS_COIN)
                state = internal_state.GUMBALLS_COIN;
        }

        public void insertCoin()
        {
            if (state == internal_state.NO_GUMBALLS_NO_COIN)
            {
                state = internal_state.NO_GUMBALLS_COIN;
                Console.WriteLine("Coin is inserted");
            }
            else if (state == internal_state.GUMBALLS_NO_COIN)
            {
                state = internal_state.GUMBALLS_COIN;
                Console.WriteLine("Coin is inserted");
            }
            else
            {
                Console.WriteLine("Coin already inserted");
            }
        }

        public void turnHandle()
        {
            if (state == internal_state.GUMBALLS_COIN)
            {
                ngumballs -= 1;
                money += 1;
                if (ngumballs == 0)
                    state = internal_state.NO_GUMBALLS_NO_COIN;
                else
                    state = internal_state.GUMBALLS_NO_COIN;
                Console.WriteLine("Take the gumall");
            }
            else if (state == internal_state.NO_GUMBALLS_COIN)
            {
                Console.WriteLine("No gumballs exist. take coin out");
                state = internal_state.NO_GUMBALLS_NO_COIN;
            }
            else
            {
                Console.WriteLine("Insert Coin");
            }
        }

        public override  string ToString()
        {
            return "GumballMachine [ngumballs=" + ngumballs + ", money=" + money
                + ", state=" + state + "]";
        }
    }
}
