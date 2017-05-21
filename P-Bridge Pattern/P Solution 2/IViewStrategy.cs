using System.Collections.Generic;

namespace P_Solution_2
{
    interface IViewStrategy
    {
        void formattedDisplay(List<Task> tasks);
    }
}