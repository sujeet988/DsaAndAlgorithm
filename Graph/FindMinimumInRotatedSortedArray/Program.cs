namespace FindMinimumInRotatedSortedArray
{
    /*
     * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
     *  Find Minimum in Rotated Sorted Array
     *  Input: nums = [3,4,5,1,2]
        Output: 1
        Explanation: The original array was [1,2,3,4,5] rotated 3 times.
     */
    internal class Program
    {
        public  static int FindMin(int[] nums)
        {
            int min = Int32.MaxValue;
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (nums[low] <= nums[mid])
                {
                    min = Math.Min(min, nums[low]);
                    low = mid + 1;
                }
                else 
                {
                    // arr[mid] <= arr[high]
                    min = Math.Min(min, nums[mid]);
                    high = mid - 1;
                }

            }
            return min;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Find Minimum in Rotated Sorted Array");

            int[] nums = { 3, 4, 5, 1, 2 };
            int min = FindMin(nums);
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}