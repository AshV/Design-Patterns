namespace C_Solution_3
{
    public interface IState
    {
        void addGumballs(GumballMachine gbm, int count);
        void insertCoin(GumballMachine gbm);
        void turnHandle(GumballMachine gbm);
    }
}