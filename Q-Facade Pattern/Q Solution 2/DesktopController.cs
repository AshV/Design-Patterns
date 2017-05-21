namespace Q_Solution_2
{
    public class DesktopController
    {
        private IOrderFacade orderFacade;

        public DesktopController(IOrderFacade orderFacade)
        {
            this.orderFacade = orderFacade;
        }

        public void orderProduct(Product product, float amount, int cardno, int cvv, Address address)
        {
            orderFacade.orderProduct(product, amount, cardno, cvv, address);
        }
    }
}