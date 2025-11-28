using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class MoveAllZerosEnd
    {
        public int[] moveZerosToEnd(int[] nums)
        {
            int n=nums.Length;
            int[] res=new int[n];
            int index = 0;
            for(int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    res[index++] = nums[i];
                }
            }
            return res;
        }
    }
}
