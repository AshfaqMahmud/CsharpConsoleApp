
namespace CsharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n");

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            //Sort.BubbleSort(arr);
            Sort.QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array:");
            for(int i = 0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            // Linked List Example
            LinkedList list = new LinkedList();
            int listSize = 5;
            Random rand = new Random();
            for (int i = 0; i < listSize; i++)
            {
                list.Append(rand.Next() % 20);
            }

            list.Print();
            Console.WriteLine(list.isThere(5));
        }
    }
}
