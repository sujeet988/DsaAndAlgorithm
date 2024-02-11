namespace FindMinimumNumberOfSubstrings
{

    /*
     * 
        * Given string ‘s’, the task is to divide a given string s into multiple substrings, with each substring containing only unique 
        characters. This means that no character should be repeated within a single substring. 
        The goal is to find the minimum number of such substrings required to satisfy this condition.

        Examples:

        Input: s = “abacaba”
        Output: 4
        Explanation: Two possible partitions are (“a”, “ba”, “cab”, “a”) and (“ab”, “a”, “ca”, “ba”). It can be shown that 4 is the minimum number of substrings needed.

        Input: s = “ssssss”
        Output: 6
        Explanation: The only valid partition is (“s”, “s”, “s”, “s”, “s”, “s”).
     */

    internal class Program
    {

        /*
         * brute force algorithm
         * We initialize an empty set and iterate through the given string. For each character encountered, 
         * we check if it is already present in the set. 
         If it is, this means that we need to start a new substring since the current substring has a repeated character. 
         We increase our answer variable and clear the set to start a new substring. We then add the current character to the set.
         After iterating through the entire string, the value of the answer variable gives us the minimum number of substrings 
         required to partition the given string such that each substring has unique characters.


        Time Complexity: O(n) where n is the length of the input string.
        Auxiliary Space: O(n) in the worst case This is because we store each character of the input string in the hash set, 
        and in the worst case, all characters of the string are unique. 

         */

        // brute force

        static int NumberofSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int ans = 1; //intliaze  with string contains only one cheracter or nou duplicated

            foreach (char c in s)
            {
                if (set.Contains(c))
                {
                    ans++;
                    set.Clear();
                }

                set.Add(c);
            }
            return ans;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("FindMinimumNumberOfSubstrings");
            // Code
            String S = "abacdec";

            Console.WriteLine("Minimum Number of Substrings with Unique Characters: " + NumberofSubstring(S));
            Console.ReadLine();
        }
    }
}