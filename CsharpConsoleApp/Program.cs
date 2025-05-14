
namespace CsharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            ////Sort.BubbleSort(arr);
            //Sort.QuickSort(arr, 0, arr.Length - 1);
            //Console.Write("Sorted array: \t\t");
            //for(int i = 0; i< arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine("\n");

            //// Linked List Example
            //LinkedList list = new LinkedList();
            //int listSize = 5;
            //Random rand = new Random();
            //for (int i = 0; i < listSize; i++)
            //{
            //    list.Append(rand.Next() % 20);
            //}
            //Console.Write("Linked list: \t\t");
            //list.Print();
            ////Console.WriteLine(list.isThere(5));
            //list.Sort();
            //Console.Write("\nSorted linked list: \t");
            //list.Print();

            //// Static Constructor Example
            //StaticCtor s = new StaticCtor();
            ////Console.WriteLine("Creating instance of StaticCtor");
            //StaticCtor s1 = new StaticCtor();


            //// example of using default

            //Console.WriteLine("Default value of Bool: " + default(bool));
            //Console.WriteLine("Default value of Object: " + default(Object));
            //Console.WriteLine("Default value of float: " + default(LinkedList));

            // record implementation using class
            Person p1 = new Person("John", 25);
            Person p2 = new Person("John", 25);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.WriteLine(p1 == "John");
            Console.WriteLine(p1 != "John");
            Console.WriteLine((string)p1);
            Console.WriteLine((int)p1);
            //Console.WriteLine((Person)"John");
            //Console.WriteLine((Person)25);
            //Console.WriteLine((Person)"John" == p1);
            //Console.WriteLine((Person)25 == p1);
            //Console.WriteLine((Person)"John" != p1);
            //Console.WriteLine((Person)25 != p1);
            //Console.WriteLine((Person)"John" == p1);
            //Console.WriteLine((Person)25 == p1);


        }

    }
}
