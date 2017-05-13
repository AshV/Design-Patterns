namespace F_Solution_2
{
 public   class TempDialogMediator:IMediator
    {
        private IEditBox fEditBox;
        private IEditBox cEditBox;
        private TempBar tempBar;
        private IButton frButton;
        private IButton flButton;
        private IButton crButton;
        private IButton clButton;

        public void notify(IEditBox editbox, float temp)
        {
            if (editbox == fEditBox)
            {
                cEditBox.update(Utils.convertFC(temp));
                tempBar.display(temp);
            }
            else
            {
                float tmp = Utils.convertCF(temp);
                fEditBox.update(tmp);
                tempBar.display(tmp);
            }
        }

        public void notify(IButton button)
        {
            if (button == frButton)
            {
                float tmp = fEditBox.getTemp() + 5;
                fEditBox.update(tmp);
                cEditBox.update(Utils.convertFC(tmp));
                tempBar.display(tmp);
            }
            else if (button == crButton)
            {
                float tmp = cEditBox.getTemp() + 5;
                fEditBox.update(Utils.convertCF(tmp));
                cEditBox.update(tmp);
                tempBar.display(tmp);
            }
            else if (button == flButton)
            {
                float tmp = fEditBox.getTemp() - 5;
                fEditBox.update(tmp);
                cEditBox.update(Utils.convertFC(tmp));
                tempBar.display(tmp);
            }
            else
            {
                float tmp = cEditBox.getTemp() - 5;
                fEditBox.update(Utils.convertCF(tmp));
                cEditBox.update(tmp);
                tempBar.display(tmp);
            }
        }

        public void setfEditBox(IEditBox fEditBox)
        {
            this.fEditBox = fEditBox;
        }

        public void setcEditBox(IEditBox cEditBox)
        {
            this.cEditBox = cEditBox;
        }

        public void setTempBar(TempBar tempBar)
        {
            this.tempBar = tempBar;
        }

        public void setFrButton(IButton frButton)
        {
            this.frButton = frButton;
        }

        public void setFlButton(IButton flButton)
        {
            this.flButton = flButton;
        }

        public void setCrButton(IButton crButton)
        {
            this.crButton = crButton;
        }

        public void setClButton(IButton clButton)
        {
            this.clButton = clButton;
        }
    }
}