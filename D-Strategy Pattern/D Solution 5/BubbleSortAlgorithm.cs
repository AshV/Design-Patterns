using System;

namespace D_Solution_5
{
    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        private IComparator comparator;

        public BubbleSortAlgorithm(IComparator comparator)
        {
            this.comparator = comparator;
        }

        public void sort()
        {
            Console.WriteLine("Sort the array using bubble sort");
        }
    }
}