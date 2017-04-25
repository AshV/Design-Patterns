using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Solution_2
{
    public class BubbleSorter : Sorter
    {
        public BubbleSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
            Console.WriteLine("sorting array using bubble sort algorithm");
        }
    }
}
