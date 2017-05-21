using System.Collections.Generic;

namespace P_Solution_2
{
    public class PriorityBasedSortStrategy : ISortStrategy
    {
        class PriorityComparator : Comparer<Task>
        {
            public override int Compare(Task x, Task y)
            {
                return x.getPriority() - y.getPriority();
            }
        }

        public void sort(List<Task> tasks)
        {
            tasks.Sort(new PriorityComparator());
        }
    }
}