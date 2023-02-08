using Ch3_21.InterfacePassing;

int[] arr = new int[10]
{
    1, 5, 4, 11, 20, 8, 2, 98, 90, 16
};
SortAlgorithm sortAlgorithm = new SortAlgorithm(arr);
sortAlgorithm.Sort();
sortAlgorithm.PrintSortedArray(new FileLogger(@"D:\Result2000.txt"));