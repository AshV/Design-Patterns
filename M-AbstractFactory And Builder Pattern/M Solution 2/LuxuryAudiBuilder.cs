namespace M_Solution_2
{
    public class LuxuryAudiBuilder
    {
        public static AudiCar getCar()
        {
            AudiCar lCar = new AudiCar();
            lCar.setGearBox(new LGearBox());
            lCar.setStereo(new LStereo());
            lCar.setWheels(new LWheel());
            return lCar;
        }
    }
}