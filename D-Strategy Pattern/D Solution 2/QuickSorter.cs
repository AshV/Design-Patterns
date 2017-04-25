using System;

namespace D_Solution_2
{
    public class QuickSorter : Sorter
    {
        public QuickSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
            Console.WriteLine("sort the array using quicksort algorithm");
        }
    }
}
