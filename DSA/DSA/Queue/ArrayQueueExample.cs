using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    internal class ArrayQueueExample
    {
        private int front, rare;
        private int size;
        private int[] arr;

        public ArrayQueueExample(int capacity)
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
            return rare == size-1;
        }
        public void Enqueue(int value)
        {
            if (isEmpty())
            {
                front = rare = 0;
                arr[0] = value;
            }else if (isFUll())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                rare = rare + 1;
                arr[rare]= value;
            }
        }
        public  void Dequeue()
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
                    front += 1;
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
            return arr.Length - 1;
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.Write("Queue elements: ");
            for (int i = front; i <= rare; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            ArrayQueueExample queue = new ArrayQueueExample(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Display();
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            queue.Display();
        }
    }
}
