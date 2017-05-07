namespace M_Solution_2
{
    public class EconomyAudiBuilder
    {
        public static AudiCar getCar()
        {
            AudiCar eCar = new AudiCar();
            eCar.setGearBox(new EGearBox());
            eCar.setStereo(new EStereo());
            eCar.setWheels(new EWheel());
            return eCar;
        }
    }
}