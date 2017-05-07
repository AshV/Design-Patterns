namespace M_Solution_4
{
    public interface ICarFactory
    {
        IGearBox getGearBox();
        IStereo getStereo();
        IWheel getWheel();
    }
}