using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class SetExample
    {
        public static List<int> GetUniqueElements(List<int> inputList)
        {
            HashSet<int> uniqueSet = new HashSet<int>(inputList);
            return uniqueSet.ToList();
        }
        public static ISet<int> RemoveDuplicate(List<int> inputList)
        {
            ISet<int> uniqueSet = new HashSet<int>();
            foreach (int item in inputList)
            {
                uniqueSet.Add(item);
            }
            return uniqueSet;
        }
        public static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(2); // Duplicate, will not be added
            Console.WriteLine("HashSet contents:");
            foreach (int item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Contains 2: " + set.Contains(2));
            set.Remove(2);
            Console.WriteLine("Contains 2 after removal: " + set.Contains(2));
            List<int> numbers = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
            List<int> uniqueNumbers = GetUniqueElements(numbers);
            Console.WriteLine("Unique elements using GetUniqueElements:");
            foreach (int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
            ISet<int> uniqueSet = RemoveDuplicate(numbers);
            Console.WriteLine("Unique elements using RemoveDuplicate:");
            foreach (int num in uniqueSet)
            {
                Console.WriteLine(num);
            }
        }
    }
}
