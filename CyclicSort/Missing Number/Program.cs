using System;
using System.Collections.Generic;
using System.Linq;

namespace Missing_Number
{
    /*
     * https://leetcode.com/problems/missing-number/description/
     * Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
     * Input: nums = [3,0,1]
       Output: 2
        Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
     */
    internal class Program
    {
        public int MissingNumber(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                int correct = arr[i];
                if (arr[i] < arr.Length && arr[i] != arr[correct])
                {
                    swap(arr, i, correct);
                }
                else
                {
                    i++;
                }
            }

            // search for first missing number
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] != index)
                {
                    return index;
                }
            }

            // case 2
            return arr.Length;
        }

        void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        // Time Complexity O(n)
        // Space complexity O(1)

        static void Main(string[] args)
        {
            Console.WriteLine("Find Missing Number using Cyclic Sort");
            int[] arr = new int[3] { 3, 0, 1 };
            Program p = new Program();
            var output = p.MissingNumber(arr);
            Console.WriteLine(output); // output 2
            Console.ReadLine();
        }
    }
}
