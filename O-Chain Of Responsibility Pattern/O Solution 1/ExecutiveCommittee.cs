namespace O_Solution_1
{
    public class ExecutiveCommittee : AbstractHandler
    {
        public ExecutiveCommittee(string name) : base(name, "Executive Committee") { }

        public bool approve(PurchaseOrder po)
        {
            System.Console.WriteLine("approved by " + ToString());
            return true;
        }
    }
}