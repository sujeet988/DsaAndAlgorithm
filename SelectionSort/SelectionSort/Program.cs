using System;

namespace SelectionSort
{
    /*
     *Selection sort -> select the greatest/lowest element and put it on right index
     * Expected Time Complexity: O(N^2).
     * Expected space Complexity: O(1).
     */
    internal class Program
    {
        // Expected Time Complexity: O(N^2).
        // Expected Auxiliary Space: O(1).
        public static void SelectionSortAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // find the max item in the remaining array and swap with correct index
                int lastIndex = arr.Length - i - 1;
                int maxIndex =GetMaxIndex(arr, 0, lastIndex);
                //swap
                int temp = arr[maxIndex];
                arr[maxIndex] = arr[lastIndex];
                arr[lastIndex] = temp;


            }

        }

        // Expected Time Complexity: O(N^2).
        // Expected Auxiliary Space: O(1).
        public static void SelectionSortDescending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // find the max item in the remaining array and swap with correct index
                int lastIndex = arr.Length - i - 1;
                int minIndex = GetMinIndex(arr, 0, lastIndex);
                //swap
                int temp = arr[minIndex];
                arr[minIndex] = arr[lastIndex];
                arr[lastIndex] = temp;


            }

        }

        private static int GetMaxIndex(int[] arr, int start, int end)
        {
            int max = start;
            for(int i=start; i<= end; i++)
            {
                if ( arr[i] > arr[max])
                {
                    max = i;
                }
            }
            return max;
        }

        private static int GetMinIndex(int[] arr, int start, int end)
        {
            int min = start;
            for (int i = start; i <= end; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort Demo");
            //unsorted Array
            int[] arr = new int[5] { 4,5,1,2,3};
            Console.WriteLine("Array before sorted");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SelectionSortAscending(arr);
            Console.WriteLine("Array after sorted in ascending");
            foreach (var item in arr)
            {
                Console.Write(item + " "); // 1 2 3 4 5
            }
            Console.WriteLine() ;
            SelectionSortDescending(arr);
            Console.WriteLine("Array after sorted in descending");
            foreach (var item in arr)
            {
                Console.Write(item + " "); // 5 4 3 2 1
            }
            Console.ReadLine();
        }
    }
}
