using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;

namespace SubarraySumEqualsK
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/subarray-sum-equals-k/
         * https://www.youtube.com/watch?v=20v8zSo2v18
         * Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
         * A subarray is a contiguous non-empty sequence of elements within an array.
         */

        //Brute Force 
        //Time  Complexity(on^3)
        //
        public static int SubarraySumByn3TimeComplexity(int[] nums, int k)
        {
            int count = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
              
                for (int j = i; j < n; j++)
                {
                    int sum = 0;
                    for (int kk=i; kk <= j; kk++)
                    {
                        sum += nums[kk];
                       
                    }
                    if (sum == k)
                    {

                        count++;
                    }

                }

            }

            return count;
        }

        //Brute Force 
        //Time  Complexity(on^2)
        //
        public static int SubarraySumByn2TimeComplexity(int[] nums, int k)
        {
            int count = 0;
            int n=nums.Length;
            for(int i=0; i < n; i++)
            {
                int sum = 0;
                for(int j=i; j < n;j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {

                        count++;
                    }

                }
               
            }

            return count;
        }

        //Optimized solution
        // using Dictionary
        public static int SubarraySumByDictionary(int[] nums, int k)
        {
            int count = 0;
            int n=nums.Length;
            Dictionary<int,int> dict=new Dictionary<int,int>();
            dict.Add(0, 1);
            int sum = 0;
            for (int i=0; i < n; i++)
            {
                sum+= nums[i];
                if (dict.ContainsKey(sum - k))
                {
                    count += dict[sum - k];
                }

                if (dict.ContainsKey(sum))
                    {
                   dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }
                

            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sub array Sum Equals K");
            int[] arr = { 3, 1, 2, 4 };
            int k = 6;
            //By Time complexity O(n^3)
            int cnt = SubarraySumByn3TimeComplexity(arr, k);
            Console.WriteLine("The number of subarrays by O(n^3) is: " + cnt);
            //By Time complexity O(n^2)
            cnt = SubarraySumByn2TimeComplexity(arr, k);
            Console.WriteLine("The number of subarrays O(n^2) is: " + cnt);
            //By Dictionary
            cnt = SubarraySumByDictionary(arr, k);
            Console.WriteLine("The number of subarrays O(n) is: " + cnt);
            Console.ReadLine();
        }
    }
}
