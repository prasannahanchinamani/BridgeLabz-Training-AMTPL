using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class ReturnIngTop3LargestElement
    {
       public static  List<int> TopThreeScores(List<int> marks)
        {
            marks.Sort();
            marks.Reverse();
            return marks.Take(3).ToList();
        
       }
        public static void Main(string[] args)
        {
            List<int> marks = new List<int>() { 85, 92, 78, 90, 88, 95, 80 };
            List<int> topThree = TopThreeScores(marks);
            Console.WriteLine("Top three scores: " + string.Join(", ", topThree));
        }
    }
}
