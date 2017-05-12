namespace O_Solution_1
{
    public class CEO : AbstractHandler
    {
        public CEO(string name) : base(name, "CEO") { }

        public bool approve(PurchaseOrder po)
        {
            if (po.getAmount() < 50000)
            {
                System.Console.WriteLine("approved by " + ToString());
                return true;
            }
            else return false;
        }
    }
}