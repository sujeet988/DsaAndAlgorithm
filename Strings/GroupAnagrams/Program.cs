using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    /*
     * https://leetcode.com/problems/group-anagrams/
     * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
     * Input: strs = ["eat","tea","tan","ate","nat","bat"]
       Output: [["bat"],["nat","tan"],["ate","eat","tea"]
     * Input: strs = [""] Output: [[""]]
     * Input: strs = ["a"] Output: [["a"]]
     */

    internal class Program
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
            {
                return new List<IList<string>>();
            }

            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            foreach (string str in strs)
            {
                char[] arr = str.ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);
                if (dic.ContainsKey(sorted))
                {
                    dic[sorted].Add(str);
                }
                else
                {
                    dic.Add(sorted, new List<string>() { str });
                }

            }
            var result = dic.Values.ToList();
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Group Anagrams Demo");
            String[] strings = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            foreach(var item in strings)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.WriteLine("array after grouping similar anagram");
            var output = GroupAnagrams(strings);
            foreach(var list in output)
            {
                Console.Write("[");
                foreach(var item in list)
                {
                    Console.Write(item+" ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
