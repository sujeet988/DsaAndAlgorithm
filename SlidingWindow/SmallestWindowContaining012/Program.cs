namespace SmallestWindowContaining012
{
    internal class Program
    {
        /*
         * https://www.geeksforgeeks.org/problems/smallest-window-containing-0-1-and-2--170637/0
         * Given a string S consisting of the characters 0, 1 and 2. Your task is to find the length of the smallest substring of string S that contains all the three characters 0, 1 and 2. 
         * If no such substring exists, then return -1.
                 * Input:
        S = 10212
        Output:
        3
        Explanation:
        The substring 102 is the smallest substring
        that contains the characters 0, 1 and 2.
         
         */

        public static int SmallesSubstring(string s)
        {
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;

            int minLength = s.Length + 1; // or  int32.MaxValue

            int start = 0;
            int end = 0;
            while (end < s.Length)
            {
                if (s[end] == '0')
                {
                    count0++;
                }
                if (s[end] == '1')
                {
                    count1++;
                }
                if (s[end] == '2')
                {
                    count2++;
                }

                while (count0 > 0 && count1 > 0 && count2 > 0)
                {
                    minLength = Math.Min(minLength, end - start + 1);
                    
                    if (s[start] == '0')
                    {
                    count0--;
                    }
                    if (s[start] == '1')
                    {
                    count1--;
                    }
                    if (s[start] == '2')
                    {
                    count2--;
                    }
                    start++;
                }
                end++;

            }

            if (minLength == s.Length + 1)
            {
                return -1;
            }
            else
            {
                return minLength;
            }



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Smallest window containing 0, 1 and 2");

            string str = "10212";
            int output = SmallesSubstring(str);
            //Console.WriteLine(output);// output 3
            //str = "12121";
            //output = SmallesSubstring(str);
            //Console.WriteLine(output); // output -1
            str = "1011212";
            output = SmallesSubstring(str);
            Console.WriteLine(output); // OUTPUT 4
            Console.ReadLine();
        }
    }
}
