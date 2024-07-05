using System;
using System.Text.Json;

namespace InsertionSort
{
    /*
     * https://leetcode.com/problems/sort-an-array/description/
     * Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
     * InsertionSort  : For Every Index , put the index element at correct order of LHS(Left  hand side)
     */
    internal class Program
    {

        // Expected Time Complexity: O(N^2).
        // Expected Auxiliary Space: O(1).
        public static void InsertionSortAscending(int[] arr)
        {
            // For Every Index , put the index element at correct order of LHS(Left  hand side)

            for(int i=0; i < arr.Length-1; i++)
            {
                for(int j=i+1; j > 0; j--)
                {
                    if (arr[j] < arr[j-1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            

        }

        // Expected Time Complexity: O(N^2).
        // Expected Auxiliary Space: O(1).
        public static void InsertionSortDescending(int[] arr)
        {
            // For Every Index , put the index element at correct order of LHS(Left  hand side)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort Demo");
            //unsorted Array
            int[] arr = new int[5] { 4, 5, 1, 2, 3 };
            Console.WriteLine("Array before sorted");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            InsertionSortAscending(arr);
            Console.WriteLine("Array after sorted in ascending");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            InsertionSortDescending(arr);
            Console.WriteLine("Array after sorted in descending");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
