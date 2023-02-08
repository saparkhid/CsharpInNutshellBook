namespace Ch3_21.InterfacePassing;

public class SortAlgorithm
{
    private int[] _array;
    public SortAlgorithm(int[] arr)
    {
        this._array = arr;
    }

    public void Sort()
    {
        QuickSort(this._array, 0, this._array.Length - 1);
    }

    public void PrintSortedArray(ILogger logger)
    {
        for (int i = 0; i < this._array.Length; i++)
        {
            logger.Log(this._array[i].ToString());
        }
    }
    private void QuickSort(int[] arr, int start, int end)
    {
        int i;
        if (start < end)
        {
            i = Partition(arr, start, end);

            QuickSort(arr, start, i - 1);
            QuickSort(arr, i + 1, end);
        }
    }

    private int Partition(int[] arr, int start, int end)
    {
        int temp;
        int p = arr[end];
        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            if (arr[j] <= p)
            {
                i++;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        temp = arr[i + 1];
        arr[i + 1] = arr[end];
        arr[end] = temp;
        return i + 1;
    }
}