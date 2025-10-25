using System;

namespace DsaAndAlgorithm.Strings.AnagramofString
{
    internal class Program
    {
        /*
       * q242 https://leetcode.com/problems/valid-anagram/
       * An anagram of a string is another string that contains the same characters, only the order of characters can be different. For example, act and tac are an anagram of each other.
       * https://takeuforward.org/data-structure/check-if-two-strings-are-anagrams-of-each-other/
       */

        // optimized approach
        // this  will handle both case  capital letter or small letter
        public static bool isAnagram(string a, string b)
        {
            //Your code here
            int chardata = 256;
            if (a.Length != b.Length)
            {
                return false;
            }
            int[] count = new int[chardata];
            for (int i = 0; i < a.Length; i++)
            {
                count[a[i]]++; // increment charcater index value by 1 like a=97 so at index 97 value will increment by 1
                count[b[i]]--; // decrement charcater index value by 1 like a=97 so at index 97 value will decrement by 1
            }
            //  check in count is at any index value is  greater than 0  or not. if any index value is greater than zero then not anagram
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    return false;
                }

            }
            return true;
        }


        //Brute Force
        //Approach: Just count the frequency of every element in Str1 and iterate through Str2 and decrease the count of every element in the frequency array. Now iterate again, if the frequency at any point is not 0
        //this means, strings are not anagrams of each other.
        // this  will handle  either  capital letter or small letter at a time
        public static bool isAnagramByfrequency(string a, string b)
        {
            // Case 1: when both of the strings have different lengths
            if (a.Length != b.Length)
            {
                return false;
            }
            int[] freq = new int[26];
            for (int i = 0; i < a.Length; i++)
            {
                freq[a[i] - 'a']++; //// if question  GIven A-Z in then use captal letter , if given a-z then use small letter
            }
            for (int i = 0; i < b.Length; i++)
            {
                freq[b[i] - 'a']--; //// if question  GIven A-Z in then use captal letter , if given a-z then use small letter
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                {
                    return false;
                }
            }

            return true;

        }
        ////Time Complexity: O(n) where n is the length of string
        ////Space Complexity: O(1)


        static void Main(string[] args)
        {
            Console.WriteLine("Anagram Demo");
            string s1 = "aabca";
            string s2 = "acaba";
            Console.WriteLine("String first " + s1);
            Console.WriteLine("String second " + s2);
            bool isanagram = isAnagramByfrequency(s1, s2);
            Console.WriteLine("Is string is anagram : " + isanagram);
            Console.ReadLine();
        }
    }
}
