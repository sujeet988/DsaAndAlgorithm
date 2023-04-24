using System;

namespace RightRotateanarraybyDPlaces
{
   /*
    * https://leetcode.com/problems/rotate-array/
    * Input: nums = [1,2,3,4,5,6,7], k = 3
        Output: [5,6,7,1,2,3,4]
    */
    
   
    internal class Program
    {
        public static void reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;
                start++;
                end--;
            }

        }
        public static void RotateRightByKplaces(int[] arr, int k)

        {
            int n = arr.Length;
            k = k % n;

            reverse(arr, n - k, n - 1); //first reverse n-k
            reverse(arr, 0, n -k-1); // then reverse 0 to n-k-1
            reverse(arr, 0, n-1); //reverse all

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Right rotaion of Array");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Console.WriteLine("Array before rotaion");
            foreach (var item in nums)
            {
                Console.Write($"{item}" + " ");
            }
            //ouput 5 6 7 1 2 3 4
            RotateRightByKplaces(nums, k);
            Console.WriteLine("Array After rotaion");
            foreach(var item in nums)
            {
                Console.Write($"{item}"+" ");
            }
            Console.ReadLine();

        }
    }
}
