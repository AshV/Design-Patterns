using static System.Console;

namespace Q_Solution_2
{
    public class OrderFacade : IOrderFacade
    {
        private IInventoryService inventoryService;
        private IPaymentService paymentService;
        private IShippingService shippingService;

        public OrderFacade(IInventoryService inventoryService, IPaymentService paymentService, IShippingService shippingService)
        {
            this.inventoryService = inventoryService;
            this.paymentService = paymentService;
            this.shippingService = shippingService;
        }

        public void orderProduct(Product product, float amount, int cardno, int cvv, Address address)
        {
            if (inventoryService.checkStock(product))
            {
                WriteLine("stock available");
                if (paymentService.pay(amount, cardno, cvv))
                {
                    WriteLine("payment successful");
                    if (shippingService.ship(product, address))
                        WriteLine("product got shipped");
                    else
                        WriteLine("product shipping failed");
                }
                else
                    WriteLine("Payment failed");
            }
            else
                WriteLine("out of stock");
        }
    }
}