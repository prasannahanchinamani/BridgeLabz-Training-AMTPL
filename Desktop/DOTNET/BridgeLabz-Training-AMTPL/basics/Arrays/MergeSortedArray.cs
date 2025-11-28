using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class MergeSortedArray
    {
        public  static int[] mergeArray(int[] nums1, int[] nums2)
        {
            int[] res=new int[nums1.Length+nums2.Length];
            int i = 0, j = 0, k = 0;
            while(i<nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    res[k++]= nums1[i++];
                }
                else
                {
                    res[k++]= nums2[j++];
                }
            }
            while(i<nums1.Length)
            {
                res[k++]= nums1[i++];
            }
            while(j<nums2.Length)
            {
                res[k++]= nums2[j++];
            }
            return res;
        }
    }
}
