using static System.Console;
using System.Collections.Generic;

namespace P_Solution_1
{
    public class NumberedView : IViewStrategy
    {
        public void formattedDisplay(List<Task> tasks)
        {
            int n = 0;
            tasks.ForEach(task =>
            {
                WriteLine(++n + task.ToString());
            });
        }
    }
}