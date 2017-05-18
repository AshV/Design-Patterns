using System.Linq;
using System.Collections.Generic;
using System;

namespace P_Solution_1
{
    public class UnsortedStrategy : ISortStrategy
    {
        public void sort(List<Task> tasks)
        {
            // Can be implemented any Shuffling logic here
            tasks.OrderBy(item => new Random().Next());
        }
    }
}