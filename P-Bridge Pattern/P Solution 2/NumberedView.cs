using static System.Console;
using System.Collections.Generic;

namespace P_Solution_2
{
    public class NumberedView : AbstractView
    {
        public NumberedView(List<Task> tasks) : base(tasks) { }

        public override void formattedDisplay()
        {
            int n = 0;
            tasks.ForEach(task =>
            {
                WriteLine((++n) + task.ToString());
            });
        }
    }
}