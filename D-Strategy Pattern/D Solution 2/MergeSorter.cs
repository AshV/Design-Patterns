using System;

namespace D_Solution_2
{
    class MergeSorter : Sorter
    {
        public MergeSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
            Console.WriteLine("sorting array using merge sort algorithm");
        }
    }
}
