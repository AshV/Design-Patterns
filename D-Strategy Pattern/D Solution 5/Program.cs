namespace D_Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 346, 34, 634, 6, 346, 4 };

            Sorter sorter = new Sorter(arr);

            IComparator comparator = new AscComparator();

            ISortAlgorithm algo = new BubbleSortAlgorithm(comparator);
            sorter.setAlgorithm(algo);
            sorter.sort();

            algo = new MergeSortAlgorithm(comparator);
            sorter.setAlgorithm(algo);
            sorter.sort();
        }
    }
}
