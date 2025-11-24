using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class CountVowelConsonents
    {
        public static void countVowelConsonentsInString(String str)
        {
            int countVowel = 0;
            int countConsonant = 0;
            str=str.ToLower();
            foreach(char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == '0' || c == 'u')
                {
                    countVowel++;
                }
                else
                {
                    countConsonant++;
                }
            }
            Console.WriteLine("Vowel Count:" + countVowel);
            Console.WriteLine("Consonant Count:"+ countConsonant);
        }
    }
}
