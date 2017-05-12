namespace O_Solution_1
{
    public class SeniorManager : AbstractHandler
    {
        public SeniorManager(string name) : base(name, "Senior Manager") { }

        public bool approve(PurchaseOrder po)
        {
            if (po.getAmount() < 1000)
            {
                System.Console.WriteLine("approved by " + ToString());
                return true;
            }
            else return false;
        }
    }
}