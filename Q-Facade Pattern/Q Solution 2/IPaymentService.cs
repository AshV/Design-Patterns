namespace Q_Solution_2
{
    public interface IPaymentService
    {
        bool pay(float amount, int cardno, int cvv);
    }
}