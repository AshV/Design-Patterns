using static System.Console;
using System.Collections.Generic;

namespace P_Solution_1
{
    public class ListView : IViewStrategy
    {
        public void formattedDisplay(List<Task> tasks)
        {
            tasks.ForEach(task => {
                WriteLine("-" + task.ToString());
            });
        }
    }
}