namespace GenerateBinaryNumbers
{
    /*
     * https://www.geeksforgeeks.org/problems/generate-binary-numbers-1587115620/1?itm_source=geeksforgeeks&itm_medium=article&itm_campaign=practice_card
        Example 2:

        Input:
        N = 5
        Output: 
        1 10 11 100 101
        Explanation: 
        Binary numbers from
        1 to 5 are 1 , 10 , 11 , 100 and 101.
     */
    internal class Program
    {
        public static List<string> GenerateBinaryUsingBruteFOrce(int N)
        {
            //Your code here
            List<string> result = new List<string>();

            for (int i = 1; i <= N; i++)
            {
                string str = getBinaryNumber(i);
                result.Add(str);
                
            }
            return result;
        }

        public static string getBinaryNumber(int n) 
        {
            string result = string.Empty;
            int remainder = 0;
            while (n > 0)
            {
                remainder = n % 2;
                n = n / 2;
                result =remainder.ToString()+result;

            }

            return result;  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Generate Binary Numbers");
            int n = 5;
            List<string> list = new List<string>();

            //using brute force
            list = GenerateBinaryUsingBruteFOrce(n);
            foreach (string s in list) 
            {
                Console.WriteLine($"{s}");
            }
            // using queue

            Console.ReadLine();

        }
    }
}
