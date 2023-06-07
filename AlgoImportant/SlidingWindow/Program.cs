using System;

namespace SlidingWindow
{

    internal class Program
    {
        /*
         * https://www.geeksforgeeks.org/window-sliding-technique/
         * https://www.geeksforgeeks.org/window-sliding-technique/
         * Given an array of integers of size ‘n’, Our aim is to calculate the maximum sum of ‘k’ 
            consecutive elements in the array.
                Input  : arr[] = {100, 200, 300, 400}, k = 2
                Output : 700 (300+400)
            Input  : arr[] = {1, 4, 2, 10, 23, 3, 1, 0, 20}, k = 4 
            Output : 39(4,2,10,23)

         */

        //Brute Force
        // using two loop
       public static int FindMaxSumBruteForce(int[] arr, int k)
        {
            int maxSum = int.MinValue;
            for(int i=0; i <= arr.Length - k; i++)
            {
                int currentsum = 0;
                for(int j=i; j < i + k; j++)
                {
                    currentsum += arr[j];
                }
                maxSum=Math.Max(maxSum, currentsum);
            }
            return maxSum;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Maximum sum of 'k' consecutive elements");
            int[] nums = { 1, 4, 2, 10, 2, 3, 1, 0 };
            int k = 3;
            int maxSum = FindMaxSumBruteForce(nums, k);
            Console.WriteLine("Maximum Sum of " + k + " consecutive elements: " + maxSum);
            Console.ReadLine();

        }
    }
}
