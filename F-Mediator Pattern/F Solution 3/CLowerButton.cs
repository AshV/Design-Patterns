using static System.Console;

namespace F_Solution_3
{
    public class CLowerButton : IWidget
    {
        public TempDialogMediator mediator;

        public CLowerButton(TempDialogMediator mediator)
        {
            this.mediator = mediator;
        }

        public void change(float temp)
        {
            WriteLine("Lower Button for Celsius is pressed");
            //     mediator.notify();
        }

        public void change()
        {
        }

        public void update(float temp)
        {
        }
    }
}