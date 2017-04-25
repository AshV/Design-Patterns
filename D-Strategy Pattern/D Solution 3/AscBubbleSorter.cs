using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Solution_3
{
    public class AscBubbleSorter : Sorter
    {
        public AscBubbleSorter(int[] arr) : base(arr)
        {
        }

        public override void sort()
        {
            Console.WriteLine("sorting array in ascending order using bubble sort algorithm");
        }
    }
}
