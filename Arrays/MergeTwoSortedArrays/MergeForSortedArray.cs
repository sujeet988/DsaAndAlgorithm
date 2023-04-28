using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MergeTwoSortedArrays
{
    /*
     * https://practice.geeksforgeeks.org/problems/merge-two-sorted-arrays-1587115620/1
     */
    internal class MergeForSortedArray
    {
        /*
         * Merge two Sorted Arrays Without Extra Space
         Problem statement: Given two sorted arrays arr1[] and arr2[] of sizes n and m in non-decreasing order. Merge them in sorted order. Modify arr1 so that it contains the first N elements and modify arr2 so that it contains the last M elements.
         Input: 
        n = 4, arr1[] = [1 3 5 7] 
        m = 5, arr2[] = [0 2 6 8 9]

        Output: 
        arr1[] = [0 1 2 3]
        arr2[] = [5 6 7 8 9]

        Explanation:
        After merging the two non-decreasing arrays, we get, 0 1 2 3 5 6 7 8 9.
         */

        //Solution1: Brute Force-

        // Intuition: We can use a new array of size n+m and put all elements of arr1 and arr2 in it, and sort it.After sorting it, but all the elements in arr1 and arr2.
        //Function to merge the arrays.
        public static void mergeWithExtraSpaces()
        {
            int[] arr1 = { 1, 4, 7, 8, 10 };
            int[] arr2 = { 2, 3, 9 };
            Console.WriteLine("Before merge:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine() ;

            int n = arr1.Length;
            int m = arr2.Length;
            //Adding third array for hold values

            int[] arr3 = new int[n + m];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                arr3[k++] = arr1[i];
            }

            for (int j = 0; j < m; j++)
            {
                arr3[k++] = arr2[j];
            }
            Array.Sort(arr3);
            //After Merging printing
            Console.WriteLine("After merge 3rd array");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]+" ");
            }
            //output : 1 2 3 4 7 8 9 10
            //Modify arr1 so that it contains the first N elements and modify arr2 so that it contains the last M elements.

            k = 0;
            for(int i=0; i < n; i++)
            {
                arr1[i] = arr3[k++];
            }
            for (int i = 0; i < m; i++)
            {
                arr2[i] = arr3[k++];
            }
            Console.WriteLine("After merge 1st and 2nd array");

            for (int i = 0; i < arr1.Length; i++) //output  1 2 3 4 7
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++) //ouput 8 9 10
            {
                Console.Write(arr2[i] + " ");
            }
             
        }
        ////Time complexity: O(n* log(n))+O(n)+O(n)
        ////Space Complexity: O(n)


        //Function to merge the arrays.
        public static void mergeWithoutExtraSpaces(int[] arr1, int[] arr2, int n, int m)
        {
            // code here 
        }
    }
}
