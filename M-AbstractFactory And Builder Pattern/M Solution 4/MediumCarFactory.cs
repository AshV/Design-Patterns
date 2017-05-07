namespace M_Solution_4
{
    public class MediumCarFactory : ICarFactory
    {
        public IGearBox getGearBox()
        {
            return new MGearBox();
        }

        public IStereo getStereo()
        {
            return new MStereo();
        }

        public IWheel getWheel()
        {
            return new MWheel();
        }
    }
}