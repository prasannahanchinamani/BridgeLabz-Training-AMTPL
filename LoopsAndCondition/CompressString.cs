using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class CompressString
    {
        public static  String compreesedString(String str)
        {
            String res = "";
            int count = 1;
            for(int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    res += str[i - 1] + count.ToString();
                    count = 1;
                }
            }
            res += str[str.Length - 1] + count.ToString();

            return res;
        }
    }
}
