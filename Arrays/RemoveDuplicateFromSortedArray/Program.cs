using System;

namespace DsaAndAlgorithm.Arrays.RemoveDuplicateFromSortedArray
{
    /*
     * https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
   Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores)
     */
    internal class Program
    {
        public static int RemoveDuplicates(int[] nums)

        {

            if (nums.Length == 0)
            {
                return 0;
            }

            int left = 1;
            for (int right = 1; right < nums.Length; right++)
            {
                if (nums[right] != nums[right - 1])
                {
                    nums[left] = nums[right];
                    left++;
                }

            }
            return left;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Duplicate From Sorted Array");
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var output =RemoveDuplicates(nums);
            Console.WriteLine(output); // ans is 5
            foreach (int i in nums)
            {
                Console.Write(i +" "); // after inplace array look like : 0 1 2 3 4 2 2 3 3 4
            }

            Console.ReadLine();
        }
    }
}
