using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.Loops
{
    internal class ReverseString
    {
        public static  String  Reverse(String str) { 
            StringBuilder newstr=new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                newstr.Append(str[i]);
            }
            return newstr.ToString();
        }
    }
}
