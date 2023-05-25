using System;
using System.Drawing;

namespace MaxSubArray_KadaneAlgorithm_
{
    internal class Program
    {

        /*
         * https://leetcode.com/problems/maximum-subarray/
         * Given an integer array nums, find the subarray with the largest sum, and return its sum
         * https://takeuforward.org/data-structure/kadanes-algorithm-maximum-subarray-sum-in-an-array/
         */

        //Brute Force
        //o(n^2)-quadratic time complexity
        public static int MaxSubArray(int[] nums)
        {

            int n = nums.Length;
            int max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentsum = 0;
                for (int j = i; j < n; j++)
                {
                    currentsum += nums[j];
                    max = Math.Max(max, currentsum);
                }
            }
            return max;
        }

        ////Time Complexity: O(N2), where N = size of the array.
        ////Reason: We are using two nested loops, each running approximately N times.
        ////Space Complexity: O(1) as we are not using any extra space.

        /// <summary>
        /// KadaneAlgorithm
        /// </summary>
        /// <param name="nums">Array</param>
        /// <returns>int</returns>
        public static int MaxSubArrayKadaneAlgorithm(int[] nums)
        {
            int currentsum = nums[0];
            int overallsum = nums[0];
            int n = nums.Length;

            for (int i = 1; i < n; i++)
            {
                if (currentsum >= 0) // if previous sum coming positive value then append else start new flow
                {
                    currentsum += nums[i];
                }
                else
                {
                    currentsum = nums[i]; // assigning new value again
                }
                if (currentsum > overallsum) //check current sum vs overllall sum
                {
                    overallsum = currentsum;
                }

            }
            return overallsum;
        }

        ////Time Complexity: O(N), where N = size of the array.
        ////Reason: We are using a single loop running N times.
        ////Space Complexity: O(1) as we are not using any extra space.

        static void Main(string[] args)
        {

            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //brute force
            Console.WriteLine("Maxium sub array");
            int maxSum = MaxSubArray(nums);
            Console.WriteLine("The maximum subarray sum is: " + maxSum); /// ans is 6

            //kadane algorithm
            Console.WriteLine("Maxium sub array using kadane algorithm");
             maxSum = MaxSubArrayKadaneAlgorithm(nums);
            Console.WriteLine("The maximum subarray using kadane algorithm  sum is: " + maxSum); //ans is 6
            Console.ReadLine();
        }


    ////The intuition of the algorithm is not to consider the subarray as a part of the answer if its sum is less than 0. A subarray with a sum less than 0 will always reduce our answer and so this type of subarray cannot be a part of the subarray with maximum sum.

    ////Here, we will iterate the given array with a single loop and while iterating we will add the elements in a sum variable.Now, if at any point the sum becomes less than 0, we will set the sum as 0 as we are not going to consider any subarray with a negative sum. Among all the sums calculated, we will consider the maximum one.

    ////Thus we can solve this problem with a single loop.

    ////Approach:
    ////The steps are as follows:

    ////We will run a loop(say i) to iterate the given array.
    ////Now, while iterating we will add the elements to the sum variable and consider the maximum one.
    ////If at any point the sum becomes negative we will set the sum to 0 as we are not going to consider it as a part of our answer.
    }
}
