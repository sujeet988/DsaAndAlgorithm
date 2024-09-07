using System;

namespace QuickSort
{
    /*
     * https://leetcode.com/problems/sort-an-array/description/
     */
    internal class Program
    {
        /*
         In this example, we use the quick sort algorithm to sort an array of integers. 
        The QuickSort method is a recursive function that performs the divide and conquer 
        trategy. It takes an array (arr), the lower index (low), and the higher index (high) 
        as parameters.

         Inside the QuickSort method, we check if low is less than high to ensure that the 
        subarray has more than one element. Then, we call the Partition method to select a 
        pivot, partition the array, and get the pivot index. After partitioning, 
        we recursively call QuickSort for the left subarray (from low to pivotIndex - 1) 
        and the right subarray (from pivotIndex + 1 to high).

         The Partition method selects the pivot element (in this case, we choose the 
        rightmost element as the pivot). It iterates through the subarray, comparing each
        element with the pivot. If an element is smaller than or equal to the pivot, 
        it swaps it with the element at the current i position and increments i. 
        Finally, it places the pivot in its correct sorted position by swapping 
        it with the element at i + 1 and returns the pivot index.
         */
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high); //Give Pivot Index

                QuickSort(arr, low, pivotIndex-1); // For element which is less than pivot element
                QuickSort(arr, pivotIndex + 1, high); // For element which is greater than pivot element
            }

        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; //// Last element we taking for pivot however we can take any element as pivot elements;
            int i = low - 1; //// 0-1 =-1, its create space for elements  less than pivot elements

            for(int j=low; j < high; j++) // j < high means j should be less tha high because at high position already pivot element

            {
                if (arr[j]< pivot)
                {
                    i++;
                    //Swap for fill vacant position
                    int tempdata = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempdata;
                }
              

            }

            // for pivot position changes, move greater element right side of pivot .
            i++;
            int temp = arr[i];
            arr[i] = pivot;
            arr[high] = temp;
            return i; ////Pivot index


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort Demo");
            int[] arr = { 6, 3, 9, 5, 8 };
            int n=arr.Length;
            QuickSort(arr, 0, n - 1);

            for(int i=0; i < n; i++)
            {
                Console.Write(arr[i] +" "); // ans is 3 5 6 8 9
            }
            Console.ReadLine();
        }
    }
}
