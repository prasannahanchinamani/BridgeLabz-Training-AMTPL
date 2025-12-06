using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Class1
    {
        static void Main(string[] args)
        {

           

            StackImpUsingLinkedList<int> stackexample = new StackImpUsingLinkedList<int>();
            stackexample.Push(1);
            stackexample.Push(2);
            stackexample.Push(3);
            stackexample.Push(4);
            stackexample.Display();
            //Console.WriteLine("Poped");
            //stackexample.Pop();
            //Console.WriteLine("Peek()");
            //Console.WriteLine();
            //Console.WriteLine(stackexample.Peek());
            Console.WriteLine("Reverse");
            Console.WriteLine();
            stackexample.ReverseList();



        }
    }
}
