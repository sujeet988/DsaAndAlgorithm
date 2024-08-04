namespace FindFirstAndLastPositionInSortedArray
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
         * Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

            If target is not found in the array, return [-1, -1].

            You must write an algorithm with O(log n) runtime complexity.
            Example 1:
            Input: nums = [5,7,7,8,8,10], target = 8
            Output: [3,4]
         */

        public static  int FindFirstLastPosition(int[] nums, int target, bool isFirstPoistion) 
        {
            int low = 0;
            int high = nums.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // (low+high)/2

                if (nums[mid] == target)
                {
                     result = mid;
                    if (isFirstPoistion) // search in left part for first poistion
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1; // search in right part for last position
                    }


                }
                else if (nums[mid] > target) 
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                     
                }


            }
            return result;

        }

        public static int[] SearchRange(int[] nums, int target)
        {

            int[] arr = new int[nums.Length];
            // find first position
            arr[0] = FindFirstLastPosition(nums,target,true);
            arr[1] = FindFirstLastPosition(nums, target, false);
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Find First and Last Position of Element in Sorted Array");

            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            var result = SearchRange(nums, target);
            Console.WriteLine(result[0] +" " + result[1]);


            Console.ReadLine();
        }
    }
}
