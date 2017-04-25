namespace D_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 6, 7, 8, 3};
            Sorter sorter = new Sorter(arr);
            sorter.sort("bubble_sort");
            sorter.sort("merge_sort");
        }
    }
}
