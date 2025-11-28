using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class DictionaryExample
    {

        public static void CountFrequency(string str)
        {
            Dictionary<char,int> frequencyCount=new Dictionary<char, int> ();
            foreach(char c in str)
            {
                if (frequencyCount.ContainsKey(c))
                {
                    frequencyCount[c]++;
                }
                else
                {
                    frequencyCount[c] = 1;
                }
            }
            foreach(KeyValuePair<char,int> kvp in frequencyCount)
            {
                Console.WriteLine("Character: " + kvp.Key + ", Frequency: " + kvp.Value);
            }
        }
        public static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict.Add(2, "Banana");
            dict.Add(3, "Cherry");
            Console.WriteLine("Dictionary contents:");
            foreach(KeyValuePair<int,string>kvp in dict)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
            //Direct inialisation
            Dictionary<int,string> dict2 = new Dictionary<int,string>()
            {
                [1]= "One",
                [2] = "Two",
                [3] = "Three"


            };
            foreach (KeyValuePair<int, string> kvp in dict2)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }
            CountFrequency("Prasanna");

        }
    }
}
