namespace F_Solution_1
{
    public class TempBar
    {
        private float temp;

        public void display(float temp)
        {
            this.temp = temp;
            System.Console.WriteLine("Temp bar: " + temp);
        }
    }
}