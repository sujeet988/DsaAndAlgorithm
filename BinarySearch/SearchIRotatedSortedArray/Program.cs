namespace SearchIRotatedSortedArray
{
    internal class Program
    {
        /*
         * Search in Rotated Sorted Array
         * https://leetcode.com/problems/search-in-rotated-sorted-array/description/
         */
        public static int Search(int[] nums, int target)
        {
            // l: The starting index
            // h: The ending index, you have to search the key in this range
            // Complete this function

            int low = 0;
            int  high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if(target == nums[mid])
                {
                    return mid;
                }
                //// left portion is sorted 

                if (nums[low] <= nums[mid]) 
                {
                    // Does the element lay in this sorted portion ?
                    if (target >= nums[low] && target <= nums[mid]) 
                    {
                        // eliminate the right portion
                        high = mid - 1;
                    }
                    else
                    {
                        // This means that the element is not in the left 
                        // sorted region , search in the right portion
                        low = mid + 1;
                    }
                }
                // / right portion is sorted 
                else
                {

                    // Does the element lay in this sorted portion ?
                    if (target >= nums[mid] && target <= nums[high]) 
                    {
                        // Eliminate the left portion 
                        // This means that the element is not in the right 
                        // sorted region, so search in the left portion
                        low = mid + 1;
                    }
                    else 
                    {
                        high = mid - 1;
                    }
                }

            }

            return -1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Search in Rotated Sorted Array");

            int[] nums = [4, 5, 6, 7, 0, 1, 2];
            int target = 0;
            var response = Search(nums, target);
            Console.WriteLine(response); // 4 0 found at index 4;


            Console.ReadLine();
        }
    }
}
