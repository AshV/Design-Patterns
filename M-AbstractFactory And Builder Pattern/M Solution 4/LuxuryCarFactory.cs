namespace M_Solution_4
{
    public class LuxuryCarFactory : ICarFactory
    {
        public IGearBox getGearBox()
        {
            return new LGearBox();
        }

        public IStereo getStereo()
        {
            return new LStereo();
        }

        public IWheel getWheel()
        {
            return new LWheel();
        }
    }
}