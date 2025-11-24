using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class FindDuplicate
    {
        public static int findDuplicate(int[] nums)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num] = 1;
                }

            }
            foreach (int val in freq.Keys)
            {
                if (freq[val] > 2)
                {
                    return val;
                }
            }
            return -1;
        }
    }
}
