using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Basics
{
    class Demo1
    {
        public static int Count;
        static Demo1()
        {
            Console.WriteLine("Static Constructor Called");
            Count = 10;
        }
        public Demo1()
        {
            Console.WriteLine("Instance Constructor Called");
        }
        public Demo1(int x)
        {
            Console.WriteLine("Instance Constructor with parameter Called: " + x);
        }
    }
}
