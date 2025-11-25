using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    internal class CircularQueueExample
    {
        private int front, rare;
        private int size;
        private int[] arr;

        public CircularQueueExample(int capacity)
        {
            arr = new int[capacity];
            size = capacity;
            front = -1;
            rare = -1;
        }
        bool isEmpty()
        {
            return front == -1;
        }
        bool isFUll()
        {
            return (rare+1)%size== front;
        }
        public void Enqueue(int value)
        {
            if (isEmpty())
            {
                front = rare = 0;
                arr[0] = value;
            }
            else if (isFUll())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                rare = (rare + 1)%size;
                arr[rare] = value;
            }
        }
        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                if (front == rare)
                {
                    front = -1;
                    rare = -1;
                }
                else
                {
                    front =(front+1)%size;
                }
            }
        }
        public int Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty underflow");
                return -1;
            }
            return arr[front];
        }

        public int Coount()
        {
            if (isEmpty())
                return 0;
            if (rare >= front)
                return rare - front - 1;
            else
                return  size;
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.Write("Queue elements: ");

            int i = front;
            while (true)
            {
                Console.Write(arr[i] + " ");
                if (i == rare) break;
                i = (i + 1) % size;
            }

            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            CircularQueueExample cq = new CircularQueueExample(4);
            cq.Enqueue(1);
            cq.Enqueue(2);
            cq.Enqueue(3);
            cq.Display();
            Console.WriteLine();
            Console.WriteLine(cq.Peek());
            cq.Dequeue();
            cq.Display();
        }
    }

}
