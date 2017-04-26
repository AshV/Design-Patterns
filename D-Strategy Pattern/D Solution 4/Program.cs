namespace D_Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 34, 534, 45, 23, 346, 34, 5 };

            Sorter sorter = new Sorter(arr);

            ISortAlgorithm algo = new BubbleSortAlgorithm();
            sorter.setAlgorithm(algo);
            sorter.sort();

            algo = new MergeSortAlgorithm();
            sorter.setAlgorithm(algo);
            sorter.sort();
        }
    }
}