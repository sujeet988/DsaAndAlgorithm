namespace CharacterCountFrequency
{
    public class Program
    {
        /*
         * Character Hashing:
         * Given the string: “abcdabefc” we are given some queries: [a, c, z]. For each query, we need to find out how many times the character appears in the string. For example, if the query is ‘a’ our answer would be 2, and if the query is ‘z’ the answer will be 0. 
         * Optimized approach using Hashing:
         In number hashing, each index of the hash array represents an element in the given array. 
        So, somehow, we need to map the characters of the string to an integer so that we can represent them using the indices of the hash array. 
        So, let’s discuss the mapping technique:
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Character Hashing ");
            string str = "abcdabehf";

            char[] input = new char[3] { 'a', 'c', 'z' };

            // Case 1 - If the string contains only lowercase letters:
            // In this case, we can map the characters like:
            // ‘a’ -> 0, ‘b’ -> 1, ‘c’ -> 2,....., ‘z’ -> 25.

            //precompute:
            int[] hash = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                hash[str[i] - 'a']++; // here str[i]--return ASCII value like for a-> 97 and 97-'a' -> 97-97-> 0 and incrementt count by 1
                                      // here str[i]--return ASCII value like for b-> 98 and 98-'a' -> 98-97-> 1 and increment count by 1. this means b staored at index 1
            }

            foreach(char ch in input)
            {
                int count = hash[ch - 'a']; // suppst ch=a then a-a=>0 and then it will zero index values
                Console.WriteLine(ch + " count is ->  " + count);
                // ans : a->2 ,c->1, z ->0

            }
            Console.ReadLine();

        }




            
        }
    }
