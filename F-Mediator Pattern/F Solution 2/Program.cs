namespace F_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TempDialogMediator mediator = new TempDialogMediator();
            TempBar tempBar = new TempBar();
            IEditBox fEditBox = new FEditBox(mediator, 0);
            IEditBox cEditBox = new CEditBox(mediator, 0);
            IButton frButton = new FRaiseButton(mediator);
            IButton flButton = new FLowerButton(mediator);
            IButton crButton = new CRaiseButton(mediator);
            IButton clButton = new CLowerButton(mediator);
            mediator.setcEditBox(cEditBox);
            mediator.setClButton(clButton);
            mediator.setCrButton(crButton);
            mediator.setfEditBox(fEditBox);
            mediator.setFlButton(flButton);
            mediator.setFrButton(frButton);
            mediator.setTempBar(tempBar);

            fEditBox.change(30);
            cEditBox.change(43);
            frButton.onClick();
            flButton.onClick();
        }
    }
}