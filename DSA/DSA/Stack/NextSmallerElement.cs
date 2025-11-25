using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    internal class NextSmallerElement
    {
        public int[] NextSmallerElemenetArr(int[] arr)
        {
            int n = arr.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count>0 && arr[stack.Peek()] >= arr[i])
                {
                    stack.Pop();
                }
                result[i]=stack.Count==0?-1:arr[stack.Peek()];
                stack.Push(i);
            }
            return result;
        }
        public static void Main(string[] args)
        {
            NextSmallerElement nextSmallerElement = new NextSmallerElement();
            int[] arr = { 4, 5, 2, 10, 8 };
            int[] result = nextSmallerElement.NextSmallerElemenetArr(arr);
            Console.WriteLine("Next Smaller Elements:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
