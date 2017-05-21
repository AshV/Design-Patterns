using static System.Console;

namespace Q_Solution_1
{
    public class MobileController
    {
        private IInventoryService inventoryService;
        private IPaymentService paymentService;
        private IShippingService shippingService;

        public MobileController(IInventoryService inventoryService, IPaymentService paymentService, IShippingService shippingService)
        {
            this.inventoryService = inventoryService;
            this.paymentService = paymentService;
            this.shippingService = shippingService;
        }

        public void orderProduct(Product product, float amount, int cardno, int cvv, Address address)
        {
            if (inventoryService.checkStock(product))
            {
                WriteLine("Stock Available");
                if (paymentService.pay(amount, cardno, cvv))
                {
                    WriteLine("Payment Successful");
                    if (shippingService.ship(product, address))
                        WriteLine("Product Got Shipped");
                    else
                        WriteLine("Product Shipping Failed");
                }
                else
                    WriteLine("Payment Failed");
            }
            else
                WriteLine("No Stock!");
        }
    }
}