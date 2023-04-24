using System;
using System.Drawing;

namespace Sort0s1s2s
{
    internal class Program
    {
        /*Given an array of size N containing only 0s, 1s, and 2s; sort the array in ascending order.
         * https://leetcode.com/problems/sort-colors/
         * https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s4231/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=sort-an-array-of-0s-1s-and-2s
         * https://takeuforward.org/data-structure/sort-an-array-of-0s-1s-and-2s/
         */

        //Approach 1
        //Brute force
        //Time Complexity: O(N* logN)
        //Space Complexity: O(1)
        public static void sort012(int[] nums)
        {
            Array.Sort(nums);
        }

        //Approach 2
        //Time Complexity: O(N)+O(N)=2N
        // Keeping count of values
        public static void sort012byKeepingcountofvalues(int[] nums)
        {
            int cnt0 = 0, cnt1 = 0, cnt2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    cnt0++;
                }
                else if (nums[i] == 1)
                {
                    cnt1++;
                }
                else
                {
                    cnt2++;
                }

            }

            for (int i = 0; i < cnt0; i++)
            {
                nums[i] = 0;
            }
            for (int i = cnt0; i < cnt0 + cnt1; i++)
            {
                nums[i] = 1;
            }
            for (int i = cnt0 + cnt1; i < cnt0 + cnt1 + cnt2; i++)
            {
                nums[i] = 2;
            }
        }

        //Optimal Approach (Dutch National flag algorithm): 
        //3 pointers apprraoch
        //Time Complexity: O(N), where N = size of the given array.
        //Reason: We are using a single loop that can run at most N times.
        //Space Complexity: O(1) as we are not using any extra space.
        public static void sort012byDutchNationalflagalgorithm(int[] nums)
        {
            int n = nums.Length ;
            int low = 0, mid = 0, high = n - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0) //for 0
                {
                    // swapping arr[low] and arr[mid]
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1) //for 1
                {
                    mid++;
                }
                else //for 2
                {
                    // swapping arr[mid] and arr[high]

                    int temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Sort- 0s1s2s");
            int[] arr = new int[] { 0, 2, 1, 2, 0, 1 };
            sort012(arr);
            Console.WriteLine("Array after sorting");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
            Console.WriteLine("");
            arr = new int[] { 0, 2, 1, 2, 0, 1 };
            sort012byKeepingcountofvalues(arr);
            Console.WriteLine("Array after sorting using Keeping count of values");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
            Console.WriteLine("");

            arr = new int[] { 0, 2, 1, 2, 0, 1 };
            sort012byDutchNationalflagalgorithm(arr);
            Console.WriteLine("Array after sorting using Dutch National flag algorithm");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
