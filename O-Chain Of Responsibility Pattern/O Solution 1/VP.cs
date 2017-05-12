namespace O_Solution_1
{
    public class VP : AbstractHandler
    {
        public VP(string name) : base(name, "VP") { }

        public bool approve(PurchaseOrder po)
        {
            if (po.getAmount() < 10000)
            {
                System.Console.WriteLine("approved by " + ToString());
                return true;
            }
            else return true;
        }
    }
}