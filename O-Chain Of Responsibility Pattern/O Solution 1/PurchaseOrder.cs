namespace O_Solution_1
{
    public class PurchaseOrder
    {
        private float amount;
        private int id;
        private string description;

        public float getAmount()
        {
            return amount;
        }

        public void setAmount(float amount)
        {
            this.amount = amount;
        }

        public int getId()
        {
            return id;
        }

        public int  setId(int id)
        {
            return id;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}