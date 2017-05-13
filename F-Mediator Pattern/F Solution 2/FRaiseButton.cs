namespace F_Solution_2
{
    public class FRaiseButton : IButton
    {
        public IMediator mediator;

        public FRaiseButton(IMediator mediator)
        {
            this.mediator = mediator;

        }

        public void onClick()
        {
            System.Console.WriteLine("Raise Button for Forenheit is pressed");
            mediator.notify(this);
        }
    }
}