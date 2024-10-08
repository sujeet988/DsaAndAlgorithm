﻿using System;
using System.Collections.Generic;

namespace FirstMissingPositive
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/first-missing-positive/description/
         */
        static int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Ignore non-positive and out-of-range values
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    // Step 2: Swap elements to their correct positions
                    int temp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = temp;
                }
            }

            // Step 3: Find the first index i where nums[i] != i+1
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            // If all elements match their indices, return n+1
            return n + 1;
        }

        //brute force approach
        public static int FirstMissingPositiveBrute(int[] nums)
        {
            int n = nums.Length;
            int max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            // max value
            Dictionary<int, bool> dict = new Dictionary<int, bool>();

            for(int i=1; i <= max+1; i++) 
            {
                dict[i] = false;
            }

            for(int i=0; i < nums.Length; i++)
            {
                dict[nums[i]] = true;
            }

            foreach(var item in dict)
            {
                if (item.Value == false)
                {
                    return item.Key;

                }

            }
            return Int32.MinValue;



        }

        static void Main(string[] args)
        {
            int[] nums = { 3, 4, -1, 1 };
            int missingPositive = FirstMissingPositive(nums);
            Console.WriteLine("First Missing Positive: " + missingPositive); // ans is 2
            //brute force
            int[] nums1 = { 1, 2, 0 };
            missingPositive = FirstMissingPositiveBrute(nums1);
            Console.WriteLine(missingPositive); // 3

            Console.ReadLine();
        }
    }
}
