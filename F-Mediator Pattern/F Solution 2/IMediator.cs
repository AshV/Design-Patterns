namespace F_Solution_2
{
    public interface IMediator
    {
        void notify(IEditBox editbox, float temp);
        void notify(IButton button);
    }
}