namespace HouseRobber
{
    /*
     * 198 https://leetcode.com/problems/house-robber/description/
     * You are a professional robber planning to rob houses along a street. 
     * Each house has a certain amount of money stashed, the only constraint stopping you from robbing each
     * of them is that adjacent houses have security systems connected and it will automatically contact 
     * the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, 
    return the maximum amount of money you can rob tonight without alerting the police.

 

Example 1:

Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
     */

    internal class Program
    {
        // using recursion processed/unprocesed approach
        // it will give tle error
        public static int maxrec(int[] nums, int index)
        {

            if (index == 0)
            {
                return nums[index];
            }

            if (index < 0)
            {
                return 0;
            }


            int procesed = nums[index] + maxrec(nums, index - 2); // procssed for n-2
            int unprocesed = 0 + maxrec(nums, index - 1); // unprocessed for n-1 approach

            return Math.Max(procesed, unprocesed);

        }


        // processed /unprocessed approach
        // using DP using Top down approach/Memziation approach
        public static int maxrecusingDp(int[] nums, int index, int[] memo)
        {

            if (index == 0)
            {
                return nums[index];
            }
            if (index < 0)
            {
                return 0;
            }

            if (memo[index] != -1)
            {
                return memo[index];
            }

            int procesed = nums[index] + maxrecusingDp(nums, index - 2, memo); // procssed for n-2
            int unprocesed = 0 + maxrecusingDp(nums, index - 1, memo); // unprocessed for n-1 approach

            return memo[index] = Math.Max(procesed, unprocesed);

        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Console.WriteLine("House Robber using  recursion");
            var output = maxrec(nums, nums.Length - 1);
            Console.WriteLine(output); // ans is 4

            Console.WriteLine("House Robber using top down memozation approach");
            int[] memo =  new int[nums.Length +1];
            Array.Fill(memo, -1);
            var output1= maxrecusingDp(nums, nums.Length-1, memo);
            Console.WriteLine(output1); // 4 ans

            Console.ReadLine();
        }
    }
}