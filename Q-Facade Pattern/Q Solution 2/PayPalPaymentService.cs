namespace Q_Solution_2
{
    public class PayPalPaymentService : IPaymentService
    {
        public bool pay(float amount, int cardno, int cvv)
        {
            return new System.Random().Next(5) > 0.5 ? true : false;
        }
    }
}