namespace F_Solution_3
{
    public class FRaiseButton : IWidget
    {
        private TempDialogMediator mediator;

        public FRaiseButton(TempDialogMediator mediator)
        {
            this.mediator = mediator;
        }

        public void change(float temp)
        {
            System.Console.WriteLine("Raise Button for Forenheit is pressed");
        //    mediator.notify();
        }

        public void change()
        {
        }

        public void update(float temp)
        {
        }
    }
}