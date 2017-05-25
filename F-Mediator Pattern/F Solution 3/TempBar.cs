namespace F_Solution_3
{
    public class TempBar : IWidget
    {
        private float temp;

        public void change(float temp)
        {
        }

        public void change()
        {
        }

        public void update(float temp)
        {
            this.temp = temp;
            System.Console.WriteLine("Temp bar: " + temp);
        }
    }
}