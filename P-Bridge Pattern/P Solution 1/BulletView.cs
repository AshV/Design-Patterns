using static System.Console;
using System.Collections.Generic;

namespace P_Solution_1
{
    public class BulletView : IViewStrategy
    {
        public void formattedDisplay(List<Task> tasks)
        {
            foreach (var task in tasks)
                WriteLine("*" + tasks.ToString());
        }
    }
}