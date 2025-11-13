using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class IntersectionArray
    {
        public static int[] intersectionArray(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();
             foreach(int num in nums1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }
             foreach(int num in nums2)
            {
                if (freq.Count>0 && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
                    
                }
             return result.ToArray();
        }

        }
   
}
