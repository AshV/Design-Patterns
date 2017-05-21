namespace Q_Solution_2
{
    public class DBInventoryService : IInventoryService
    {
        public bool checkStock(Product product)
        {
            return new System.Random().Next(5) > 0.4 ? true : false;
        }
    }
}