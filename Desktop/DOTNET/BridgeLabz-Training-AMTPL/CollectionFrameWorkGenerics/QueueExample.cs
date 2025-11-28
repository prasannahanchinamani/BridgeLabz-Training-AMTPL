using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class QueueExample
    {
        public void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack=new Stack<T>();
          
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

        }
        public static void Main(string[] args)
        {
            QueueExample queueExample = new QueueExample();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("Original Queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            queueExample.ReverseQueue(queue);
            Console.WriteLine("Reversed Queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Queue<string> stringQueue = new Queue<string>();    
            stringQueue.Enqueue("A");
            stringQueue.Enqueue("B");
            stringQueue.Enqueue("C");
            foreach (string item in stringQueue)
            {
                Console.WriteLine(item);
            }
            queueExample.ReverseQueue(stringQueue);
            foreach (string item in stringQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
