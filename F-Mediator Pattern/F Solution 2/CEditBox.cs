using static System.Console;

namespace F_Solution_2
{
    public class CEditBox : IEditBox
    {
        private IMediator mediator;
        private float tempInC;

        public CEditBox(IMediator mediator, float tempInC)
        {
            this.mediator = mediator;
            this.tempInC = tempInC;
        }

        public void change(float temp)
        {
            WriteLine("Edited value in Ceditbox:" + temp);
            mediator.notify(this, temp);
        }

        public float getTemp()
        {
            return tempInC;
        }

        public void update(float temp)
        {
            tempInC = temp;
            WriteLine("CEditBox: " + tempInC);
        }
    }
}