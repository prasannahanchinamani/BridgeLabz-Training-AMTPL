using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class FirstnonRepeating
    {
        public static char? firstnonRepeating(String st)
        {
            for(int i = 0; i < st.Length; i++)
            {
                bool isFound = true;
                for (int j = 0; j < st.Length; j++)
                {
                    if (i != j && st[j] == st[i])
                    {
                        isFound = false;
                        break;
                    }
                }
                    if (isFound)
                        return st[i];
                
            }
            return null;
        }
    }
}
