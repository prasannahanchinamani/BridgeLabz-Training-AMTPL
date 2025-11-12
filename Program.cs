using System;
using ConditionAndLoops.Loops;
using ConditionAndLoops.LoopsAndCondition;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string : ");
        string input = Console.ReadLine();

        string reversed = ReverseString.Reverse(input);
        Console.WriteLine("Reversed string: " + reversed);

        bool isPalindrome = PalindromeCheck.isPalindrome(input);
        Console.WriteLine("Is Palindrome: " + isPalindrome);
        Console.WriteLine(" Anagram Checking :");
        Console.WriteLine("String input 1");
        String input1 = Console.ReadLine();
        Console.WriteLine("String input 2");
        String input2 = Console.ReadLine();

        Anagram.isAnagram(input1, input2);
        Console.WriteLine("Count Vowel And Consonant");
        CountVowelConsonents.countVowelConsonentsInString(input);
        LongestSubstringWithoutRepeating.longestSubstring(input);
        String res = CompressString.compreesedString(input);
        Console.WriteLine(res);

        char? result = FirstnonRepeating.firstnonRepeating("aabbcc");
        if (result.HasValue)
            Console.WriteLine("First unique: " + result);
        else
            Console.WriteLine("No unique character found.");

        Console.Write("Is String Rotation of Another:"+ StringRotation.isRotationOfAnother("waterbottle", "erbottlewat"));
    }
}