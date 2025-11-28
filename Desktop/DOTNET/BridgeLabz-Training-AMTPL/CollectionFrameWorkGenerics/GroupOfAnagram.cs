using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.CollectionFrameWorkGenerics
{
    internal class GroupOfAnagram
    {
        public static Dictionary<string,List<string>> GroupOfAnanagram(List<String> words)
        {
            var result=new Dictionary<string, List<string>>();
            foreach(string word in words)
            {
                char[] ch = word.ToCharArray();
                Array.Sort(ch);
                string sortedWord = new string (ch);
                if (result.ContainsKey(sortedWord)){
                    result[sortedWord].Add(word);
                }
                else
                {
                    result[sortedWord] = new List<string>() { word };
                }
            }
            return result;
        
        }
        public static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "eat", "tea", "tan", "ate", "nat", "bat"
            };
            var groupedAnagrams = GroupOfAnanagram(words);
            foreach(var kvp in groupedAnagrams)
            {
                Console.WriteLine("Anagrams for key " + kvp.Key + ": " + string.Join(", ", kvp.Value));
            }
        }   
    }
}
