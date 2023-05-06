using System;
using System.Drawing;

namespace ValidAnagram
{
    internal class Program
    {
        /*
         * q242 https://leetcode.com/problems/valid-anagram/
         * An anagram of a string is another string that contains the same characters, only the order of characters can be different. For example, act and tac are an anagram of each other.
         * https://takeuforward.org/data-structure/check-if-two-strings-are-anagrams-of-each-other/
         */

        //Brute Force
        //Approach: Sort both the string and compare each and every letter of both strings. If all letters matched then, print true. Otherwise, print false.
        public static bool isAnagram(string a, string b)
        {
            // Case 1: when both of the strings have different length
            if (a.Length != b.Length)
            {
                return false;
            }
            char[] charsa = a.ToCharArray();
            char[] charsab = b.ToCharArray();

            Array.Sort(charsa);
            Array.Sort(charsab);
            int n=charsa.Length;
            // Case 2: check if every character of str1 and str2 matches with each other
            for (int i=0;  i < n; i++)
            {
                if (charsa[i] != charsab[i])
                {
                    return false;
                }
            }

            return true;

        }
        //Time Complexity: O(nlogn) since sorting function requires nlogn iterations.
        //Space Complexity: O(1)


        //Brute Force
        //Approach: Just count the frequency of every element in Str1 and iterate through Str2 and decrease the count of every element in the frequency array. Now iterate again, if the frequency at any point is not 0
        //this means, strings are not anagrams of each other.
        public static bool isAnagramByfrequency(string a, string b)
        {
            // Case 1: when both of the strings have different lengths
            if (a.Length != b.Length)
            {
                return false;
            }
           int[] freq=new int[26];
            for(int i=0;i < a.Length; i++)
            {
                freq[a[i] - 'A']++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                freq[b[i] - 'A']--;
            }

            for(int i=0; i < freq.Length; i++)
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
            String Str1 = "INTEGER";
            String Str2 = "TEGERNI";
            //Brute Force
            Console.WriteLine(isAnagram(Str1,Str2)); //output : true

            //Optimized Approach
            Console.WriteLine(isAnagramByfrequency(Str1, Str2)); //output : true
            Console.ReadLine();


        }
    }
}
