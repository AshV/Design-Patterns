using static System.Console;

namespace F_Solution_2
{
    public class FEditBox : IEditBox
    {
        private IMediator mediator;
        private float tempInF;

        public FEditBox(IMediator mediator, float tempInF)
        {
            this.mediator = mediator;
            this.tempInF = tempInF;
        }

        public void change(float temp)
        {
            WriteLine("Edited value in Feditbox:" + temp);
            mediator.notify(this, temp);
        }

        public float getTemp()
        {
            return tempInF;
        }

        public void update(float temp)
        {
            tempInF = temp;
            WriteLine("FEditbox:" + tempInF);
        }
    }
}