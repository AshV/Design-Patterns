using static System.Console;

namespace F_Solution_1
{ 
    public class CEditBox
    {
        private FEditBox fEditBox;
        private TempBar tempBar;
        private float tempInC;

        public CEditBox(TempBar tempBar, float tempInC)
        {
            this.tempBar = tempBar;
            this.tempInC = tempInC;
        }

        public void change(float temp)
        {
            WriteLine("Edited value in Ceditbox:" + temp);
            fEditBox.update(Utils.convertCF(temp));
            tempBar.display(Utils.convertCF(temp));
        }

        public void update(float temp)
        {
            tempInC = temp;
            WriteLine("CEditBox: " + tempInC);
        }

        public void serfEditBox(FEditBox fEditBox)
        {
            this.fEditBox = fEditBox;
        }
    } 
}