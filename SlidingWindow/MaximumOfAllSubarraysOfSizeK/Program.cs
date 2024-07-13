namespace MaximumOfAllSubarraysOfSizeK
{
    /*
     * https://leetcode.com/problems/sliding-window-maximum/description/
     */
    internal class Program
    {
        /* Given an array arr[] of size N and an integer K.Find the maximum for each and every contiguous subarray of size K.
         * N = 9, K = 3
 arr[] = 1 2 3 1 4 5 2 3 6
 Output: 
 3 3 4 5 5 5 6 
 Explanation: 
 1st contiguous subarray = {1 2 3} Max = 3
 2nd contiguous subarray = {2 3 1} Max = 3
 3rd contiguous subarray = {3 1 4} Max = 4
 4th contiguous subarray = {1 4 5} Max = 5
 5th contiguous subarray = {4 5 2} Max = 5
 6th contiguous subarray = {5 2 3} Max = 5
 7th contiguous subarray = {2 3 6} Max = 6
         */

        //Complete this function
        public static List<int> max_of_subarraysBruteForce(int[] arr, int n, int k)
        {
            List<int> output = new List<int>();

            for (int i = 0; i < (n - k) + 1; i++)
            {


                int maxvalue = Int32.MinValue;

                for (int j = i; j < i + k; j++)
                {
                    if (arr[j] > maxvalue)
                    {
                        maxvalue = arr[j];
                    }

                }
                output.Add(maxvalue);


            }
            return output;
        }

        //Sliding window
        public static List<int> max_of_subarraysSlidingWindow(int[] arr, int n, int k)
        {
            List<int> output = new List<int>();


            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Constant Sliding Window");
            int[] arr = new int[] { 1 , 2, 3, 1, 4, 5 ,2 ,3, 6 };
            int k = 3; // window size
            List<int>? output = null;
            Console.WriteLine("using brute force");
            output = max_of_subarraysBruteForce(arr, arr.Length, k);
            foreach(int i in output)
            {
                Console.Write(i); // output :   3 3 4 5 5 5 6 
            }
            Console.WriteLine();
            Console.WriteLine("using sliding ");
            output = max_of_subarraysSlidingWindow(arr, arr.Length, k);
            foreach (int i in output)
            {
                Console.WriteLine(i); // output :   3 3 4 5 5 5 6 
            }

            Console.ReadLine();
        }
    }
}