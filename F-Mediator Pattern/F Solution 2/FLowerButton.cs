namespace F_Solution_2
{
    public class FLowerButton : IButton
    {
        private IMediator mediator;

        public FLowerButton(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void onClick()
        {
            System.Console.WriteLine("Lower Button for Forenheit is pressed");
            mediator.notify(this);
        }
    }
}