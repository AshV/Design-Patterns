using System.Collections.Generic;

namespace P_Solution_1
{
public    interface IViewStrategy
    {
        void formattedDisplay(List<Task> tasks);
    }
}