namespace D_Solution_3
{
    public abstract class Sorter
    {
        private int[] array;

        public Sorter(int[] arr)
        {
            array = arr;
        }

        public abstract void sort();
    }
}
