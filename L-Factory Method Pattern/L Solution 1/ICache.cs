namespace L_Solution_1
{
    public interface ICache
    {
        void put(string key, int value);
        int get(string key);
    }
}