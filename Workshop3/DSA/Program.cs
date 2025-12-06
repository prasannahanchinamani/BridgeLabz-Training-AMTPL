using System;
using System.Collections;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListExample<int> list = new LinkedListExample<int>();

            Console.WriteLine("Adding elements at start:");
            list.AddAtStarting(10);
            list.AddAtStarting(20);
            list.AddAtStarting(30);
            PrintList(list);

            Console.WriteLine("\nAdding elements at end:");
            list.AddAtend(40);
            list.AddAtend(50);
            PrintList(list);

            Console.WriteLine("\nInsert element at index 2:");
            list.insertAtIndex(25, 2);
            PrintList(list);

            Console.WriteLine("\nDelete element at start:");
            list.DeleteAtstarting();
            PrintList(list);

            Console.WriteLine("\nDelete element at end:");
            list.DeleteAtEnd();
            PrintList(list);

            Console.WriteLine("\nDelete element at index 2:");
            list.DeleteAtIndex(2);
            PrintList(list);

            Console.WriteLine("\nIs list empty? " + list.IsEmpty());

            list.Reverse();
            PrintList(list);




            StackExample<int> stack = new StackExample<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Top element: " + stack.Peek()); 
            stack.Pop();
            Console.WriteLine("Top element after Pop: " + stack.Peek()); 
            Console.WriteLine("Stack count: " + stack.CountStack());

            QueueExample<int> queue = new QueueExample<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Dequeuing...");
            queue.Deque(); // removes 10

            Console.WriteLine("Dequeuing...");
            queue.Deque(); // removes 20
        }

        }

       
     
        
        static void PrintList(LinkedListExample<int> list)
        {
            Node<int> temp = list.head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        
    }

}
