using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class TargetSum
    {
      public  static  void targetSum(int[]nums,int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"Pair found: {nums[i]}, {nums[j]}");
                    }
                }
            }
        }
    }
}
