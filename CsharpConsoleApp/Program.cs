
namespace CsharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            //Sort.BubbleSort(arr);
            Sort.QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array");
            for(int i = 0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
