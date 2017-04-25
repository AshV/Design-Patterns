using System;

namespace D_Solution_3
{
    public class DescBubbleSorter : Sorter
    {
        public DescBubbleSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
            Console.WriteLine("sorting array in descending order using bubble sort algorithm");
        }
    }
}
