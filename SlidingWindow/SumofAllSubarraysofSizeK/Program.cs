namespace SumofAllSubarraysofSizeK
{
    internal class Program
    {
        /*
         * https://www.geeksforgeeks.org/sum-of-all-subarrays-of-size-k/
         * Given an array arr[] and an integer K, the task is to calculate the sum of all subarrays of size K.
         * Input: arr[] = {1, 2, 3, 4, 5, 6}, K = 3 
            Output: 6 9 12 15 
            Explanation: 
            All subarrays of size k and their sum: 
            Subarray 1: {1, 2, 3} = 1 + 2 + 3 = 6 
            Subarray 2: {2, 3, 4} = 2 + 3 + 4 = 9 
            Subarray 3: {3, 4, 5} = 3 + 4 + 5 = 12 
            Subarray 4: {4, 5, 6} = 4 + 5 + 6 = 15

            Input: arr[] = {1, -2, 3, -4, 5, 6}, K = 2 
            Output: -1, 1, -1, 1, 11 
            Explanation: 
            All subarrays of size K and their sum: 
            Subarray 1: {1, -2} = 1 – 2 = -1 
            Subarray 2: {-2, 3} = -2 + 3 = -1 
            Subarray 3: {3, 4} = 3 – 4 = -1 
            Subarray 4: {-4, 5} = -4 + 5 = 1 
            Subarray 5: {5, 6} = 5 + 6 = 11 
         */
        static void calcSum(int[] arr, int n, int k)
        {
            // Loop to consider every  
            // subarray of size K 
            for (int i = 0; i <= n - k; i++)
            {

                // Initialize sum = 0 
                int sum = 0;

                // Calculate sum of all elements 
                // of current subarray 
                for (int j = i; j < k + i; j++)
                    sum += arr[j];

                // Print sum of each subarray 
                Console.Write(sum + " ");
            }
        }

        static void calcSumSlidingWindow(int[] arr, int n, int k)
        {
            // Loop to consider every  
            // subarray of size K 
            for (int i = 0; i <= n - k; i++)
            {

                // Initialize sum = 0 
                int sum = 0;

                // Calculate sum of all elements 
                // of current subarray 
                for (int j = i; j < k + i; j++)
                    sum += arr[j];

                // Print sum of each subarray 
                Console.Write(sum + " ");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all subarrays of size K");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int n = arr.Length;
            int k = 3;

            // Function Call 
            Console.WriteLine("using brute force");
            calcSum(arr, n, k); // ans :   6 9 12 15 
            Console.WriteLine();
            Console.WriteLine("using Sliding window");
            calcSumSlidingWindow(arr, n, k); // ans :   6 9 12 15 

            Console.ReadLine();

        }
    }
}