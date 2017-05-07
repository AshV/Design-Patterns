namespace M_Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory factory = new EconomyCarFactory();
            AudiCar car1 = new AudiCar();
            car1.setGearBox(factory.getGearBox());
            car1.setStereo(factory.getStereo());
            car1.setWheels(factory.getWheel());
            System.Console.WriteLine(car1);

            factory = new MediumCarFactory();
            AudiCar car2 = new AudiCar();
            car2.setGearBox(factory.getGearBox());
            car2.setStereo(factory.getStereo());
            car2.setWheels(factory.getWheel());
            System.Console.WriteLine(car2);
        }
    }
}