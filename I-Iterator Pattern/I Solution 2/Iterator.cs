namespace I_Solution_2
{
    public interface Iterator
    {
        bool hasNext();
        MenuItem next();
        void reset();
    }
}