using System;

namespace FirstMissingPositive
{
    internal class Program
    {

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

        static void Main(string[] args)
        {
            int[] nums = { 3, 4, -1, 1 };
            int missingPositive = FirstMissingPositive(nums);
            Console.WriteLine("First Missing Positive: " + missingPositive);
            Console.ReadLine();
        }
    }
}
