using System;
using System.Security.Cryptography;

namespace MergeSort
{
    internal class Program
    {
        /*
        * In this example, we use the merge sort algorithm to sort an array of integers. 
        The Merge method is responsible for merging two sorted subarrays into one sorted array.

        The MergeSort method is a recursive function that performs the divide and conquer strategy.
        It takes an array (arr), the lower index (low), and the higher index (high) as parameters.

        Inside the MergeSort method, we first check if low is less than high to ensure that the 
        subarray has more than one element. Then, we calculate the mid index by averaging low and
        high. We recursively call MergeSort twice to sort the left half and right half of the array.
        Finally, we merge the two sorted halves using the Merge method.

        In the Merge method, we create temporary arrays (leftArray and rightArray) to store the left and right subarrays. 
        We copy the corresponding elements from the original array to the temporary arrays. 
        Then, using three pointers (i, j, and k), we compare elements from the temporary arrays 
        and merge them into the original array in sorted order.
         */

        public static void Divide(int[] arr , int startIndex, int endIndex) 
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int midIndex = startIndex + (endIndex - startIndex) / 2;  //// overflow condition (low + high) / 2;
            Divide(arr, startIndex, midIndex);
            Divide(arr, midIndex+1, endIndex);
            ConquerMerge(arr, startIndex, midIndex,endIndex);
        }

        public static void ConquerMerge(int[] arr, int startIndex, int midIndex, int endIndex)
        {
            int[] merged = new int[endIndex - startIndex+1];
            int index1 = startIndex; // traverse left sorted subarray
            int index2 = midIndex+1;  //// traverse right sorted subarray
            int k = 0; // will merge both arrays into original array (arr)
            while (index1 <= midIndex && index2<= endIndex)
            {
                if (arr[index1] <= arr[index2])
                {
                    merged[k] = arr[index1];
                    index1++;
                }
                else
                {
                    merged[k] = arr[index2];
                    index2++;
                }
                k++;    
            }
            // it may be possible that one of the arrays is not complete
            // copy the remaining elements
            // below two while loop  either one loop at time


            // if elements on the left half are still left //
            while (index1 <= midIndex)
            {
                merged[k] = arr[index1];
                k++;
                index1++;
            }
            //  if elements on the right half are still left //
            while (index2 <= endIndex)
            {
                merged[k] = arr[index2];
                k++;
                index2++;
            }

            // transfering all elements from temporary to arr //
            for (int i = 0,  j = startIndex; i < merged.Length; i++,j++)
            {
                arr[j] = merged[i];
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Merged Sort Example");
            int[] arr = new int[] { 6, 3, 9, 5, 2, 8 };
            Divide(arr, 0, arr.Length - 1);
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
            Console.ReadLine();
        }
    }
}
