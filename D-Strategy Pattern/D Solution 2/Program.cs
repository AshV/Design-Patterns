using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 345, 45, 567, 56, 45, 634, 745, };

            Sorter sorter = new BubbleSorter(arr);
            sorter.sort();

            sorter = new MergeSorter(arr);
            sorter.sort();

            sorter = new QuickSorter(arr);
            sorter.sort();
        }
    }
}
