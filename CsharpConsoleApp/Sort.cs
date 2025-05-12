using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    internal class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Last i elements are already sorted
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the element found is greater than the next element
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            // Divide and conquer strategy
            if(low<high)
            {
                // Find the pivot element such that
                // element smaller than the pivot are on the left
                // and elements greater than the pivot are on the right

                int pivot = Partition(arr,low, high);

                QuickSort(arr, low, pivot - 1); // Recursively sort elements before partition
                QuickSort(arr, pivot + 1, high); // Recursively sort elements after partition


            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            //throw new NotImplementedException();
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j< high; j++)
            {
                // If current element is smaller than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++; // increment index of smaller element
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i + 1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i+1;
        }
    }
}
