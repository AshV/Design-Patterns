namespace M_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractAudiBuilder builder = new EconomyAudiBuilder();
            AudiCar car1 = builder.getCar();
            System.Console.WriteLine(car1);

            builder = new MediumAudiBuilder();
            AudiCar car2 = builder.getCar();
            System.Console.WriteLine(car2);
        }
    }
}