namespace Q_Solution_2
{
    public interface IOrderFacade
    {
        void orderProduct(Product product, float amount, int cardno, int cvv, Address address);
    }
}