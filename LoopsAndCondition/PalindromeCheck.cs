using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class PalindromeCheck
    {
        public static  bool isPalindrome(String str)
        {
            if (str == null)
                return false;
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }

            return true;
        }
    }
}
