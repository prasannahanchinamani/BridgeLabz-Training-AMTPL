using System;
using System.Linq;

namespace basics.Arrays
{
    internal class MissingNumber
    {
        public static int missingNumber(int[] nums)
        {
            int n = nums.Length+1;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = nums.Sum();
            return Math.Abs(expectedSum - actualSum);
        }

    }
}