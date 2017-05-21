using static System.Console;
using System.Collections.Generic;

namespace P_Solution_2
{
    public class BulletView : AbstractView
    {
        public BulletView(List<Task> tasks) : base(tasks) { }

        public override void formattedDisplay()
        {
            tasks.ForEach(task =>
            {
                WriteLine("*" + task.ToString());
            });
        }
    }
}