using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    internal class StackExample
    {
        private int front, rare;
        private int size;
        private int[] arr;
        public StackExample(int size)
        { 
            arr = new int[size];
            front = -1;
            rare = -1;
        }
        public  bool IsEmpty()
        {
            return front == -1;
        }
        public bool IsFull()
        {
            return rare == arr.Length - 1;
        }
        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            if (IsEmpty())
            {
                front = rare = 0;
                arr[0] = value;
            }
            else if (IsFull())
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            else if(!IsFull())
            {
                rare++;
                arr[rare] = value;
            }
        }

        public void Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
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
                    rare--;
                }
            }
        }
        public int Peek()
        {
            if ((IsEmpty()))
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
         return arr[rare];

        }
        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rare; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
        public static void Main(String[] args)
        {
                       StackExample stack = new StackExample(5);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.PrintStack();
            Console.WriteLine();
            Console.WriteLine("Top element is: " + stack.Peek());
            stack.Pop();
            stack.PrintStack();
            Console.WriteLine();
            Console.WriteLine("Top element is: " + stack.Peek());
        }

    }
}
