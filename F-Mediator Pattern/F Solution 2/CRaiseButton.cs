namespace F_Solution_2
{
    public class CRaiseButton : IButton
    {
        private IMediator mediator;

        public CRaiseButton(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void onClick()
        {
            System.Console.WriteLine("Raise Button for Celsius is pressed");
            mediator.notify(this);
        }
    }
}