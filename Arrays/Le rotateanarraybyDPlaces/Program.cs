using System;
using System.Drawing;
using System.Net.Http.Headers;

namespace Le_rotateanarraybyDPlaces
{
    /*
     * https://takeuforward.org/arrays/left-rotate-an-array-by-d-places/
     * https://practice.geeksforgeeks.org/problems/reversal-algorithm5340/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=reversal-algorithm
     * 
     * Input: N = 7, array[] = {1,2,3,4,5,6,7} , d = 3
       Output: 4 5 6 7 1 2 3
       Explanation: The array is rotated to the left by 3 positions.
     */

    internal class Program
    {

        public static void LeftRotate(int[] arr, int n, int d)
        {
            if (n == 0)
            {
                return;
            }
            // Get the effective number of rotations:
            d = d % n;
            //checking if d is a multiple of n:
            if (d == 0) return;

            int[] temp = new int[d]; // temporary array

            //step 1: Copying first d elements
            // in the temporary array:
            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[i];
            }
            // step 2: Shift last (n-d) elements
            // to the left by d places in the given array:
            for (int i = d; i < n; i++)
            {
                arr[i - d] = arr[i];
            }

            //step 3: Place the elements of the temporary
            // array in the last d places of the given array:
            for (int i = n - d; i < n; i++)
            {
                arr[i] = temp[i - (n - d)];
            }
        }
        ////Time Complexity: O(d)+O(n-d)+O(d) = O(n+d), where n = size of the array, d = the number of rotations.Each term represents each loop used in the code.
        ////Space Complexity: O(d) extra space as we are using a temporary array of size d.

        //Optimized Approach(without using any extra space): Using “Reversal Algorithm” 
      public  static void leftRotateByOptimized(int[] arr, int n, int d)
        {

            if (n == 0)
            {
                return;
            }
            // Get the effective number of rotations:
            d = d % n;
            //step 1:
            Reverse(arr, 0, d - 1);
            //step 2:
            Reverse(arr, d, n - 1);

            //step 3:
            Reverse(arr, 0, n - 1);

        }
            private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp= arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void Main(string[] args)
        {

            int n = 7;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 3;
    
            Console.WriteLine("Before rotation:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            ///////////////////////////
            Console.WriteLine("Left Roation of array by brute force");
            Program.LeftRotate(arr, n, d);
            Console.WriteLine("After rotation:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " "); // ans : 4 5 6 7 1 2 3
            Console.WriteLine();
            Console.WriteLine("Reversal Algorithm");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            Program.leftRotateByOptimized(arr1, n, d);
            Console.WriteLine("After rotation:");
            for (int i = 0; i < n; i++)
                Console.Write(arr1[i] + " "); // ans is 4 5 6 7 1 2 3
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
