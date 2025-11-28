using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class LinkedListExample
    {
        public static void LinkedListDemo()
        {
            LinkedList<string>list=new LinkedList<string>();
            list.AddFirst("hi");
            list.AddLast("hello");
            list.AddFirst("GoodMorning");
            list.AddLast("Welcome");
            foreach(string str in list)
            {
                Console.WriteLine(str);
            }
            list.Remove("hi");
            list.RemoveFirst();
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }
        public static void Main(string[] args)
        {
            LinkedListDemo();
        }
    }
}
