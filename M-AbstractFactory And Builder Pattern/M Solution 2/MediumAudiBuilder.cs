namespace M_Solution_2
{
    public class MediumAudiBuilder
    {
        public static AudiCar getCar()
        {
            AudiCar mCar = new AudiCar();
            mCar.setGearBox(new MGearBox());
            mCar.setStereo(new MStereo());
            mCar.setWheels(new MWheel());
            return mCar;
        }
    }
}