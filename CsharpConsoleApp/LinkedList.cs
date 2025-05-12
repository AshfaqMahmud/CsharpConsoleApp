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
            if(temp.Next == null) return;

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
    }
}
