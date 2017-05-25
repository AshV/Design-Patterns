using static System.Console;

namespace F_Solution_3
{
    public class FEditBox : IWidget
    {
        private TempDialogMediator mediator;
        private float tempInF;

        public FEditBox(TempDialogMediator mediator, float tempInF)
        {
            this.mediator = mediator;
            this.tempInF = tempInF;
        }

        public float getTemp()
        {
            return tempInF;
        }

        public void change(float temp)
        {
            WriteLine("Edited value in Feditbox:" + temp);
            mediator.notify(this, temp);
        }

        public void change()
        {
        }

        public void update(float temp)
        {
            tempInF = temp;
            WriteLine("FEditbox:" + tempInF);
        }
    }
}