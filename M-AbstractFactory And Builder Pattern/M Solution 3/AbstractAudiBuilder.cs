namespace M_Solution_3
{
    public abstract class AbstractAudiBuilder
    {
        public abstract IGearBox getGearBox();
        public abstract IWheel getWheel();
        public abstract IStereo getStereo();

        public AudiCar getCar()
        {
            AudiCar audiCar = new AudiCar();
            audiCar.setGearBox(getGearBox());
            audiCar.setStereo(getStereo());
            audiCar.setWheels(getWheel());
            return audiCar;
        }
    }
}