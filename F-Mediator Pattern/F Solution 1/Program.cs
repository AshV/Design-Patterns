namespace F_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TempBar tempBar = new TempBar();
            FEditBox fEditBox = new FEditBox(tempBar, 0);
            CEditBox cEditBox = new CEditBox(tempBar, 0);
            fEditBox.setcEditBox(cEditBox);
            // cEditBox.setfEditBox(fEditBox);
            // Circular Dependency
            FRaiseButton fRaiseButton = new FRaiseButton(fEditBox, cEditBox, tempBar);
            FLowerButton fLowerButton = new FLowerButton(fEditBox, cEditBox, tempBar);

            fEditBox.change(30);
            cEditBox.change(43);
            fRaiseButton.onClick();
            fLowerButton.onClick();
        }
    }
}