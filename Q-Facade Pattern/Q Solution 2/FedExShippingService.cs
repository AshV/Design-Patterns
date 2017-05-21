namespace Q_Solution_2
{
    public class FedExShippingService : IShippingService
    {
        public bool ship(Product product, Address address)
        {
            return new System.Random().Next(5) > 5 ? true : false;
        }
    }
}