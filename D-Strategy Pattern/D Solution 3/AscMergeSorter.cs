using System;

namespace D_Solution_3
{
    public class AscMergeSorter : Sorter
    {
        public AscMergeSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
            Console.WriteLine("sorting array in ascending order using merge sort algorithm");
        }
    }
}
