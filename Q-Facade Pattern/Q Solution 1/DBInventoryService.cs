namespace Q_Solution_1
{
    public class DBInventoryService : IInventoryService
    {
        public bool checkStock(Product product)
        {
            return new System.Random().Next(5) > 5 ? true : false;
        }
    }
}