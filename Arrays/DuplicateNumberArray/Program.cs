using System;

namespace DuplicateNumberArray
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/find-the-duplicate-number/
         * Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.There is only one repeated number in nums, return this repeated number.
         */
        public static int FindDuplicate(int[] nums)
        {

            int start = 0;
            int dupl = 0;
            Array.Sort(nums);
            for (int end = 1; end < nums.Length; end++)
            {

                if (nums[start] == nums[end])
                {
                    dupl = nums[start];
                }
                start++;
            }

            return dupl;

        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 4, 2, 2 };
            var output = FindDuplicate(nums);
            Console.WriteLine("Duplcicate Element in array is "+output);
            Console.ReadLine();
        }
    }
}
