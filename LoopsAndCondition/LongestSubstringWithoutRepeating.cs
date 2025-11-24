using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class LongestSubstringWithoutRepeating
    {
        public static void longestSubstring(String str)
        {
            int maxLength = 0;
            string longest = "";

            for (int i = 0; i < str.Length; i++)
            {
                String curr = "";
                for (int j = i; j < str.Length; j++)
                {
                    if (curr.Contains(str[j]))
                        break;
                    curr += str[j];
                    if(curr.Length>maxLength)
                    {
                        maxLength = curr.Length;
                        longest=curr;
                    }
                }
            }
            Console.WriteLine($"Longest substring without repeating characters: {longest}");
            Console.WriteLine($"Length: {maxLength}");
            foreach (char c in longest)
            {
                Console.Write(c);
            }
        }
    }
}
