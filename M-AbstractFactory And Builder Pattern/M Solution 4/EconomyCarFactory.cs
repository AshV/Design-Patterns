namespace M_Solution_4
{
    public class EconomyCarFactory : ICarFactory
    {
        public IGearBox getGearBox()
        {
            return new EGearBox();
        }

        public IStereo getStereo()
        {
            return new EStereo();
        }

        public IWheel getWheel()
        {
            return new EWheel();
        }
    }
}