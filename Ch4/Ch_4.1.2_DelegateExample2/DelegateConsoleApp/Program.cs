using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsoleApp
{
    internal class Program
    {
        delegate void SorterFunction(int[] unsortedArray);

        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 8, 4, 7, 1, 3 };

            SorterFunction sorter = InsertionSort;
            Console.WriteLine("Sorting using insertion sort algorithm");
            sorter(arr);
        ConsoleApp1    PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine(sorter.Method);
            Console.WriteLine();
            Console.WriteLine(sorter.Target);
            int[] arr2 = { 5, 2, 8, 4, 7, 1, 3 };

            sorter = QuickSort;
            Console.WriteLine("Sorting using quick sort algorithm");
            sorter(arr2);
            PrintArray(arr2);

            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
        }


        #region Quick sort
        static void QuickSort(int[] arr)
        {
            DoQuickSort(arr, 0, arr.Length - 1);
        }
        static void DoQuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    DoQuickSort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    DoQuickSort(arr, pivot + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        #endregion

        #region Insertion sort
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        #endregion
    }
}
