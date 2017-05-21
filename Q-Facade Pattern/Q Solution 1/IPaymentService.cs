namespace Q_Solution_1
{
    public interface IPaymentService
    {
        bool pay(float amount, int cardno, int cvv);
    }
}