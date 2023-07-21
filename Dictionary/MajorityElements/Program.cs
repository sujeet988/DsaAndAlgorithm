using System;
using System.Collections.Generic;

namespace MajorityElements
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/majority-element/
         * The majority element is the element that appears more than ⌊n / 2⌋ times. 
         * You may assume that the majority element always exists in the array.
         * Input: nums = [3,2,3]
           Output: 3
           Input: nums = [2,2,1,1,1,2,2]
           Output: 2
         */

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int,int> keyValuePairs= new Dictionary<int,int>();
            foreach(var item in nums)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                }
                else
                {
                    keyValuePairs.Add(item, 1);
                }
            }

            int majority = 0;
            int n = nums.Length;
            foreach (var item in keyValuePairs.Keys)
            {
                if (keyValuePairs[item]> n / 2)
                {
                    majority = item;
                }
            }

            return majority;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MajorityElements");
            int[] num = new int[] { 3,2,3 };
            var output = MajorityElement(num);
            Console.WriteLine(output); // output 3
            Console.ReadLine();
        }
    }
}
