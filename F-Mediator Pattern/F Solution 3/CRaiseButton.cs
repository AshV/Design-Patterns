using static System.Console;

namespace F_Solution_3
{
    public class CRaiseButton : IWidget
    {
        private TempDialogMediator mediator;

        public CRaiseButton(TempDialogMediator mediator)
        {
            this.mediator = mediator;
        }

        public void change(float temp)
        {
            WriteLine("Raise Button for Celsius is pressed");
            //          mediator.notify();
        }

        public void change()
        {
        }

        public void update(float temp)
        {
        }
    }
}