using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoops.LoopsAndCondition
{
    internal class StringRotation
    {
        public static  bool isRotationOfAnother(String s1, String s2)
        {
            if (s1.Length != s2.Length)
                return false;
            String combined = s1 + s2;
            if(combined.Contains(s2))
                return true;
            return false;
        }
    }
}
