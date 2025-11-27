using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class Anagram
    {
        public static void isAnagram(String s1,String s2)
        {
            int[] count = new int[256];
            if(s1.Length!= s2.Length)
            {
                Console.WriteLine("Not a Anagram");
                return;
            }
             foreach(char c in s1)
            {
                count[c]++;
            }
             foreach(char c in s2)
            {
                count[c]--;
            }
             foreach(int c in count)
            {
                if (c != 0)
                {
                    Console.WriteLine("Not a Anagram");
                    return;
                }

            }

            Console.WriteLine("Not a Anagram"); 
        }
    }
}
