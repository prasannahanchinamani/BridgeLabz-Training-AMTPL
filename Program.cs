using System;

using basics.LoopsAndCondition;
using basics.Arrays;

class Program
{
    public static void Main(string[] args)
    {
        //Console.Write("Enter a string : ");
        //string input = Console.ReadLine();

        //string reversed = ReverseString.Reverse(input);
        //Console.WriteLine("Reversed string: " + reversed);

        //bool isPalindrome = PalindromeCheck.isPalindrome(input);
        //Console.WriteLine("Is Palindrome: " + isPalindrome);
        //Console.WriteLine(" Anagram Checking :");
        //Console.WriteLine("String input 1");
        //String input1 = Console.ReadLine();
        //Console.WriteLine("String input 2");
        //String input2 = Console.ReadLine();

        //Anagram.isAnagram(input1, input2);
        //Console.WriteLine("Count Vowel And Consonant");
        //CountVowelConsonents.countVowelConsonentsInString(input);
        //LongestSubstringWithoutRepeating.longestSubstring(input);
        //String res = CompressString.compreesedString(input);
        //Console.WriteLine(res);

        //char? result = FirstnonRepeating.firstnonRepeating("aabbcc");
        //if (result.HasValue)
        //    Console.WriteLine("First unique: " + result);
        //else
        //    Console.WriteLine("No unique character found.");

        
      //Console.Write("Is String Rotation of Another:"+ StringRotation.isRotationOfAnother("waterbottle", "erbottlewat"));
        //Console.WriteLine("Longest Palindromic Subsequence: " + LongestPalindromeSubsequence.LongestPalindromicSubsequence("babad"));


        Console.WriteLine("Arrays Problems:");
        int[] a = { 1,2, 4, 5 };
        int missing = MissingNumber.missingNumber(a);
        Console.WriteLine("Missing Number is: " + missing);
        //Object 
        MoveAllZerosEnd obj=new MoveAllZerosEnd();
        int[] res=obj.moveZerosToEnd(new int[]{0,1,0,3,12});
        Console.WriteLine("After Moving Zeros to End: " + string.Join(", ", res));
        int[] nextGreater = NextGreaterElement.nextGreaterElement(new int[]{ 1,2,3,4,5});
          Console.WriteLine("Next Greater Elements: " + string.Join(", ", nextGreater));
        Console.WriteLine("Majority of Elements in the String:");
        MajorityOfElements.majorityElemensts("abbbc");
        Console.WriteLine("Target Sum Pairs:");
         int [] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int targetSum = 10;
        TargetSum.targetSum(arr, targetSum);
        Console.WriteLine("Rotate Array:");
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        int k = 3;
        int[] rotated = RotateArrayByK.rotateArray(nums, k);
        Console.WriteLine(string.Join(" ", rotated));
        int[] intersection=IntersectionArray.intersectionArray(new int[]{1,2,2,1}, new int[]{2,2});
        foreach(var item in intersection)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine("Duplicate Zeros in Array:");
       Console.WriteLine(FindDuplicate.findDuplicate(new int[]{1,2,0,2,2,3,0,4,5,0}));
       

        Console.WriteLine("Merge Two Sorted Arrays:");
        int[] merged=MergeSortedArray.mergeArray(new int[]{1,3,5}, new int[]{2,4,6});
        foreach(var item in merged)
        {
            Console.Write(item+" ");
        }
    }
}