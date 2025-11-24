using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics.Arrays
{
    internal class NextGreaterElement
    {
        public static int[] nextGreaterElement(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[5];
            Stack<int> stack = new Stack<int>();
            for(int i = n - 1; i >= 0; i--)
            {
                while(stack.Count>0 && stack.Peek() <= arr[i])
                {
                    stack.Pop();
                }

                res[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(arr[i]);
            }

            return res;
        }
    }
}
