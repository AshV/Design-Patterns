using static System.Console;

namespace F_Solution_3
{
    public class CEditBox : IWidget
    {
        private TempDialogMediator mediator;
        private float tempInC;

        public CEditBox(TempDialogMediator mediator, float tempInC)
        {
            this.mediator = mediator;
            this.tempInC = tempInC;
        }

        public float getTemp()
        {
            return tempInC;
        }

        public void change(float temp)
        {
            WriteLine("Edited value in Ceditbox:" + temp);
            mediator.notify(this, temp);
        }

        public void change()
        {
        }

        public void update(float temp)
        {
            tempInC = temp;
            WriteLine("CEditBox:" + tempInC);
        }
    }
}