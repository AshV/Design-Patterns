namespace D_Solution_5
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
