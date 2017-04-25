using System;

namespace D_Solution_1
{
    public class Sorter
    {
        private int[] array;

        public Sorter(int[] arr)
        {
            array = arr;
        }

        private void bubble_sort()
        {
            Console.WriteLine("sorting array using bubble sort algorithm");
        }

        private void merge_sort()
        {
            Console.WriteLine("sorting array using merge sort algorithm");
        }

        public void sort(string algo)
        {
            if (algo.Equals("bubble_sort"))
                bubble_sort();
            else if (algo.Equals("merge_sort"))
                merge_sort();
            else
                Console.WriteLine("Invalid Sort Algorithm");
        }
    }
}
