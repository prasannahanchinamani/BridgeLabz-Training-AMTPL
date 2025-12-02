using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.LINQ
{
    internal class LinqObjectExample
    {
        public static void Main()
        {
            string[] names = { "Prasanna", "Prajwal","PRASanna", "Pramodh", "Vinay", "Muttu" };
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            //Select

            var selectexample = //names.Where(n => n.Length > 6);
                                    from n in names
                                    where n.Length>6
                                    select n;
            foreach (string n in selectexample)
            {
                Console.WriteLine(n);
            }
            //selectMany
            var slectmany = /*new[] {numbersA,numbersB}
                                .SelectMany(a => a)
                                .Where(n =>n>5);*/
                              from arr in new[] { numbersA, numbersB }
                              from n in arr
                              where n>5
                              select n;

            foreach (var n in slectmany)
            {
               Console.WriteLine(n);
            }
            //order by 
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = /* from word in words 
                             orderby word.Length descending
                             select word; */
                               words.OrderBy(n => n.Length).ToList();

            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            //Count function
            var distinctCount = //names.Select(n => n.ToLower()).Distinct().Count();
                                 (from word in words select word).Count();
            Console.WriteLine("Count: " + distinctCount);


            //Filtering: Where, OfType
            var even = numbersA.Where(n => n % 2 == 0);
            foreach(var n in even)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("OfType");
            IList<object> mix = new object[] { 1, "hello", 2.5, "world" };

            var strings = mix.OfType<int>();
            foreach(var s in strings)
            {
                Console.WriteLine($"{s}");
            }
            //Projection: Select, SelectMany
            var listOfLists = new List<int[]>
        {
     new[] { 1, 2 },
     new[] { 3, 4 }
     };

            var flat = listOfLists.SelectMany(a => a);

            foreach (var n in flat)
            {
                Console.WriteLine(n);
            }


        }
    }
}
