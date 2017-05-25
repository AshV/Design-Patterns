namespace F_Solution_3
{
    public class FLowerButton : IWidget
    {
        private TempDialogMediator mediator;

        public FLowerButton(TempDialogMediator mediator)
        {
            this.mediator = mediator;
        }

        public void change(float temp)
        {
            System.Console.WriteLine("Lower Button for Forenheit is pressed");
            //  mediator.notify();
        }

        public void change()
        {
        }

        public void update(float temp)
        {
        }
    }
}