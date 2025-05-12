using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    public class Node
    {
        public int Data;
        public Node? Next;

        public Node(int Data)
        {
            this.Data = Data;
            Next = null;
        }
    }

    internal class LinkedList
    {
        public Node? Head;
        public LinkedList()
        {
            Head = null;
        }

        public void Append(int data)
        {
            Node newnode = new Node(data);
            if (Head == null)
            {
                Head = newnode;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newnode;
            }
        }

        public void Prepend(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = Head;
            Head = newnode;
        }

        public void Delete(int key)
        {
            if (Head == null) return;
            if (Head.Data == key)
            {
                Head = Head.Next;
                return;
            }
            Node temp = Head;
            while (temp.Next != null && temp.Next.Data != key)
            {
                temp = temp.Next;
            }

            // if data was not found
            if (temp.Next == null) return;

            // if data was found and not meet the previous condition
            temp.Next = temp.Next.Next;
        }

        public void Print()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public bool isThere(int key)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Data == key) return true;
                temp = temp.Next;
            }
            return false;
        }

        /// <summary>
        /// Sorts the linked list using the merge sort algorithm.
        /// 
        /// Merge sort is a divide-and-conquer algorithm that splits the list into smaller parts,
        /// sorts each part, and then merges them back together in sorted order. The common steps include:
        /// 
        /// 1. Base Case: If the list is empty or contains only one element, it is already sorted.
        /// 
        /// 2. Splitting the List:
        ///    - Use two pointers (slow and fast) to find the middle of the list.
        ///    - The slow pointer moves one node at a time while the fast pointer moves two.
        ///    - When the fast pointer reaches the end, the slow pointer will be at the midpoint.
        ///    - Split the list into two halves from this midpoint.
        /// 
        /// 3. Recursively Sorting the Sublists:
        ///    - Apply merge sort recursively on the left and right halves.
        /// 
        /// 4. Merging Sorted Halves:
        ///    - Merge the two sorted halves into a single sorted list.
        ///    - Compare the nodes from each half and build up the sorted list.
        /// 
        /// Time Complexity: O(n log n) on average.
        /// 
        /// Note: The implementation should handle edge cases such as lists with duplicate elements
        /// and lists where the number of elements is not even.
        /// </summary>
        public void Sort()
        {
            // Implementation of merge sort for the linked list should follow these steps:
            // 1. Create a helper function to split the list into two halves.
            // 2. Create a recursive merge sort function that sorts and returns the new head.
            // 3. Create a merge helper function that merges two sorted linked lists.
            // 4. Set the Head of this LinkedList to the result of the recursive merge sort.

            Head = MergeSort(Head);
        }
        private Node MergeSort(Node head)
        {
            if(head == null || head.Next == null)
            {
                // already sorted
                return head;
            }

            // Split the list into halves
            Node middle = GetMiddle(head);
            Node nextToMiddle = middle.Next;
            middle.Next = null; // Split the list into two halves

            Node left = MergeSort(head); // Sort the left half
            Node right = MergeSort(nextToMiddle); // Sort the right half

            return Merge(left, right);

        }

        private Node GetMiddle(Node head)
        {
            if (head == null) return head;
            Node slow = head, fast = head;
            while(fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }

        // Function to merge the sorted lists
        private Node Merge(Node left, Node right)
        {
            if (left == null) return right;
            if (right == null) return left;

            // start with the smaller value node
            if(left.Data <= right.Data)
            {
                left.Next = Merge(left.Next, right);
                return left;
            }
            else
            {
                right.Next = Merge(left, right.Next);
                return right;
            }
        }
    }
}
