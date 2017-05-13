namespace F_Solution_1
{
    public class FLowerButton
    {
        private FEditBox fEditBox;
        private CEditBox cEditBox;
        private TempBar tempBar;

        public FLowerButton(FEditBox fEditBox, CEditBox cEditBox, TempBar tempBar)
        {
            this.fEditBox = fEditBox;
            this.cEditBox = cEditBox;
            this.tempBar = tempBar;
        }

        public void onClick()
        {
            System.Console.WriteLine("Lower Button for Forenheit is pressed");
            float f = fEditBox.getTempInF() - 5;
            fEditBox.update(f);
            cEditBox.update(Utils.convertFC(f));
            tempBar.display(f);
        }
    }
}