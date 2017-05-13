namespace F_Solution_2
{
    public class CLowerButton : IButton
    {
        private IMediator mediator;

        public CLowerButton(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void onClick()
        {
            System.Console.WriteLine("Lower Button for Celsius is pressed");
            mediator.notify(this);
        }
    }
}