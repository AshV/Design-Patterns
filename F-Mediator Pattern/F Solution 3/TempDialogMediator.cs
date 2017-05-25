using System.Collections.Generic;

namespace F_Solution_3
{
    public class TempDialogMediator
    {
        private List<IWidget> widgets;

        public TempDialogMediator()
        {
            widgets = new List<IWidget>();
        }

        public void addWidget(IWidget widget)
        {
            widgets.Add(widget);
        }

        public void notify(IWidget widget, float temp)
        {
            widgets.ForEach(wd =>
            {
                if (wd != widget)
                    wd.update(temp);
            });
        }
        //when button is a source of event, how do we know which editbox value have to read?
    }
}