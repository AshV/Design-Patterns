namespace M_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AudiCar eCar = EconomyAudiBuilder.getCar();
            System.Console.WriteLine(eCar);

            AudiCar mCar = MediumAudiBuilder.getCar();
            System.Console.WriteLine(mCar);
        }
    }
}