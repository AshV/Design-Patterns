using System;

namespace D_Solution_5
{
    public class MergeSortAlgorithm : ISortAlgorithm
    {
        private IComparator comparator;

        public MergeSortAlgorithm(IComparator comparator)
        {
            this.comparator = comparator;
        }

        public void sort()
        {
            Console.WriteLine("Sort array using mergesort");
        }
    }
}
