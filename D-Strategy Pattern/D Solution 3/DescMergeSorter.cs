using System;

namespace D_Solution_3
{
    public class DescMergeSorter : Sorter
    {
        public DescMergeSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
           Console.WriteLine("sorting array in descending order using merge sort algorithm");
        }
    }
}
