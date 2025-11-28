using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class ListExample
    {
        public static void RemoveAllOccurance(List<int> list,int target)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    list.RemoveAt(i);
                }
            }
        }
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 2, 5, 2, 6 };
            Console.WriteLine("Original List: " + string.Join(", ", list));
            int target = 2;
            RemoveAllOccurance(list, target);
            Console.WriteLine("List after removing all occurrences of " + target + ": " + string.Join(", ", list));

            List<int> list2 = new List<int>();
            list2.Add(10);
            list2.Add(20);
            list2.Add(30);
            list2.AddRange(new int[] { 40, 50, 60 });
            foreach( int c in list2)
            {
                Console.WriteLine(c);
            }
        }
    }
}
