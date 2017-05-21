using System.Collections.Generic;

namespace P_Solution_2
{
    public class DueDateBasedSortStrategy : ISortStrategy
    {
        class DueDateComparator : Comparer<Task>
        {
            public override int Compare(Task x, Task y)
            {
                return x.getDuedate().CompareTo(y.getDuedate());
            }
        }

        public void sort(List<Task> tasks)
        {
            tasks.Sort(new DueDateComparator());
        }
    }
}