using System;

namespace PeakElement
{
    internal class Program
    {
        /*
         * A peak element is an element that is strictly greater than its both neighbors(left and right).
         * https://leetcode.com/problems/find-peak-element/
         * https://www.youtube.com/watch?v=OINnBJTRrMU
         *  If the array contains multiple peaks, return the index to any of the peaks.
         * The following corner cases give a better idea about the problem. 

            If the input array is sorted in a strictly increasing order, the last element is always a peak element. For example, 50 is peak element in {10, 20, 30, 40, 50}.
            If the input array is sorted in a strictly decreasing order, the first element is always a peak element. 100 is the peak element in {100, 80, 60, 50, 20}.
            If all elements of the input array are the same, every element is a peak element.
            in first  element left element element is not available so only right side compare, if its is greater than right then its a peak element
            in last  element, right element  is not available so only left side compare, if its is greater than right then its a peak element
            there can be mutiple peak  element
         */

        //Brute Force.Linear Search
        // Binary Search
        public static int FindPeakElement(int[] nums)
        {

            int n = nums.Length;     // First or last element is peak element
            if (n == 1) //arry size is 1 so by default first  index element is peak elements
                return 0;
            if (nums[0] >= nums[1]) // if first element is greater than right neighbors the first element is peak element so index would 0
                return 0; //first element
            if (nums[n - 1] >= nums[n - 2]) //  if last element is greater than their left neighbor, then peak element would be last element, index would be n-1
                return n - 1;

            // Check for every other element
            for (int i = 1; i < n - 1; i++)
            {

                // Check if the neighbors are smaller
                if (nums[i] >= nums[i - 1] &&
                    nums[i] >= nums[i + 1])
                    return i;
            }
            return 0;

        }

        //optimized solution
        // Binary Search
        public static int FindPeakElementBinarySearch(int[] nums)
        {
            int n = nums.Length;     // First or last element is peak element
            if (n == 1) // if array has only one elements
                return 0;
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2; //mid element

                if (mid > 0 && mid < n - 1)
                {
                    if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                    {
                        return mid;
                    }
                    else if (nums[mid - 1] > nums[mid])
                    {
                        right = mid - 1;
                    }
                    else if (nums[mid + 1] > nums[mid])
                    {
                        left = mid + 1;
                    }
                }
                else if (mid == 0)
                {
                    if (nums[0] > nums[1])
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else if (mid == n - 1)
                {
                    if (nums[n - 1] > nums[n - 2])
                    {
                        return n - 1;
                    }
                    else
                    {
                        return n - 2;
                    }

                }
            }


            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Peak Element");
            int[] arr = { 1, 3, 20, 4, 11, 0 };
            // By Brute Force
            Console.WriteLine("Index of a peak point is " +
                             FindPeakElement(arr));


            // By Binary search
            Console.Write("Index of a peak point is " +
                              FindPeakElementBinarySearch(arr));
            Console.ReadLine();
        }
    }
}
