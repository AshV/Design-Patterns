namespace R_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.addText("understanding the cost with disk reads");
            document.addImage("1.jpg", "One");
            document.addImage("2.jpg", "Two");
            document.open();
        }
    }
}
