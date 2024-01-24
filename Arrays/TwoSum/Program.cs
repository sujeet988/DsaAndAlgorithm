using System;
using System.Collections.Generic;

namespace DsAlgo.Sujeet
{

    /*
     * LeetCode Link
     * https://leetcode.com/problems/two-sum/
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target
     */
    internal class Program
    {
        //brute force solution
        //neted loop
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for(int i=0; i< nums.Length; i++)
            {
                for(int j=i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;

            //tc : o(n^2) sc -0(1)
        }
        /// <summary>
        /// using dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] OptimizedSolutionusingHashMap(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int,int> prevvalue= new Dictionary<int,int>();//create dictionart for hold previous value
            for (int i = 0; i < nums.Length; i++)
            {
                int  difference= target - nums[i];//find difference, if difference found in dictionary then  sum target found
                if (prevvalue.ContainsKey(difference))
                {
                    result[0] = prevvalue[difference];
                    result[1] = i;

                }
                else
                {
                    prevvalue.Add(nums[i], i); ///add key with index number;
                }
            }

            //t.c : o(n) , s.c : o(n)

                return result;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 11, 15 };
            int target = 9;
            //Brute Force solution
            var response= TwoSum(arr, target);
            foreach(var item in response)
            {
                Console.Write(item+" ");
            }
            // output index  0,1

            //Optimized Solution
            response = OptimizedSolutionusingHashMap(arr, target);
            foreach (var item in response)
            {
                Console.Write(item + " ");
            }

            // output 0,1
            Console.ReadLine();
        }
    }
}
