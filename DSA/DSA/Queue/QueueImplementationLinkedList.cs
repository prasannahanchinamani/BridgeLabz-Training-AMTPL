using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    internal class QueueImplementationLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int  data) { 
                this.data = data;
                this.next = null;
            }
        }
        public class Queue
        {
            private Node front;
            private Node rare;
            public Queue()
            {
                front = null;
                rare = null;
            }
            bool IsEmpty()
            {
                return front==null;
            }
           public void Enqueue(int value)
            {
                if (IsEmpty())
                {
                    front = rare = new Node(value);
                    return;
                }
                else
                {
                    rare.next=new Node(value);
                    rare = rare.next;

                }
            }
            public void Dequeue()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Is Empty UnderFlow");
                    return;
                }
                front = front.next;
            }
            public int Peek()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Is Empty UnderFlow");
                    return -1;
                }
                return front.data;
            }
            public void display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }

                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine("null");
            }
        }
        public static void Main(string[] args)
        {
            Queue lsq = new Queue();
            lsq.Enqueue(1);
            lsq.Enqueue(2);
            lsq.Enqueue(3);
            lsq.Enqueue(4);
            lsq.Enqueue(5);
            Console.WriteLine();
            lsq.display();
            lsq.Dequeue();
            Console.WriteLine(lsq.Peek());
            lsq.display();
        }
    }
}
