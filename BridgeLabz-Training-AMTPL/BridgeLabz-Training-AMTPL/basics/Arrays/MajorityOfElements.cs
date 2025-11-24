using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class MajorityOfElements
    {
        public static  void majorityElemensts(String str)
        {
            Dictionary<char, int> countFrequncy = new Dictionary<char,int>();
            foreach (char c in str){
                if (countFrequncy.ContainsKey(c))
                {
                    countFrequncy[c]++;
                }
                else
                {
                    countFrequncy[c] = 1;
                }

            }

            foreach (var pair in countFrequncy)
            {
                if (pair.Value > str.Length / 2)
                {
                    Console.WriteLine($"Majority Element: {pair.Key}, Count: {pair.Value}");
                }
                
            }
           

            //return countFrequncy;
        }
    }
}
