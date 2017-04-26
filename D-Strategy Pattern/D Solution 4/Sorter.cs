using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Solution_4
{
    public class Sorter
    {
        private int[] array;
        private ISortAlgorithm algo;

        public Sorter(int[] arr)
        {
            array = arr;
        }

        public void setAlgorithm(ISortAlgorithm algo)
        {
            this.algo = algo;
        }

        public void sort()
        {
            algo.sort();
        }
    }
}
