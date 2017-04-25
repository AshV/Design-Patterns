namespace D_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 346, 3, 523, 634, 76, 234, 2346, 3, 35 };

            Sorter sorter = new AscBubbleSorter(arr);
            sorter.sort();

            sorter = new DescMergeSorter(arr);
            sorter.sort();
        }
    }
}
