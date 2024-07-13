using System.Collections.Generic;

namespace MaximumSumOfKkonsecutiveElements
{
    /*
     
    https://www.geeksforgeeks.org/problems/max-sum-subarray-of-size-k5313/1
    Given an array of integers Arr of size N and a number K. 
    Return the maximum sum of a subarray of size K.
    NOTE*: A subarray is a contiguous part of any given array.

    Example 1:
        Input:
        N = 4, K = 2
        Arr = [100, 200, 300, 400]
        Output:
        700
        Explanation:
        Arr3  + Arr4 =700,
        which is maximum.

    Example 2:
        Input:
        N = 4, K = 4
        Arr = [100, 200, 300, 400]
        Output:
        1000
        Explanation:
        Arr1 + Arr2 + Arr3 + Arr4 =1000,
        which is maximum.


    */
    internal class Program
    {
        /// <summary>
        /// Time Complexity 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int bruteForce(int k, int[] arr,int n)
        {

            //Declare a variable and assigned value 0
            int maxSum = 0;

            //Traverse an array from 0 to n-k
            for (int i = 0; i <= n - k; i++)
            {

                int sum = 0;

                //Run a loop from i to i+k
                for (int j = i; j < i + k; j++)
                {
                    sum = sum + arr[j];
                }

                //Keep track of maximum sum
                maxSum = Math.Max(sum, maxSum);
            }

            return maxSum;
        }


        //Sliding window 
        // O(n) time complexity
        public static long maximumSumSubarraySlidingWindow(int K, int[] arr, int N)
        {
            int start = 0;
            int sum = 0;
            long maxSum = long.MinValue;

            for (int end = 0; end < arr.Length; end++)
            {
                sum += arr[end];

                /*
                 * we compute the sum of first window whose size is equal to k and after that, 
                 * we increment both start and end pointer by one position. 
                 * Now the sum of next window can be computed by simply adding the new element and removing the 
                 * previous element from the current window sum. 
                 * At each step we also keep track of the maximum sum obtained so far.
                 */
                if (end >= K - 1)
                {
                    maxSum = Math.Max(sum, maxSum);
                    sum = sum - arr[start];
                    start++;
                }

            }
            return maxSum;

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Sum Subarray of Size K demo");
            int[] arr = new int[6] { 2, 1, 5, 1, 3, 2 };
            int k = 3;

            // using brute force
            int result = bruteForce(k, arr,arr.Length);
            Console.WriteLine("Using brute force "+ result);


            //using sliding window

            
            // First subarray -  { 2, 1, 5} Sum = 8
            // Second subarray - { 1, 5, 1} Sum = 7   Subtracted 2 from this window and added 1
            // Third subarray -  { 5, 1, 3} Sum = 9   Subtracted 1 from this window and added 3
            // Fourth subarray - { 1, 3, 2} Sum = 6   Subtracted 5 from this window and added 2

            var result1 = maximumSumSubarraySlidingWindow(k, arr, arr.Length);
            Console.WriteLine("using Sliding window "+ result1);
            Console.ReadLine();
        }

    }
}