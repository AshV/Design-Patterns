namespace M_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AudiCar eCar = new AudiCar();
            eCar.setGearBox(new EGearBox());
            eCar.setStereo(new EStereo());
            eCar.setWheels(new EWheel());
            System.Console.WriteLine(eCar);

            AudiCar xCar = new AudiCar();
            xCar.setGearBox(new EGearBox());
            xCar.setStereo(new MStereo());
            xCar.setWheels(new LWheel());
            System.Console.WriteLine(xCar);
        }
    }
}

//Problem: any level of part can be assigned to any car object