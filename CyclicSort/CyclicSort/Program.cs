using System;

namespace CyclicSort
{
    /*
     * https://www.geeksforgeeks.org/cycle-sort/
     * Cyclic Sort
     */
    internal class Program
    { 
        
        // Expected Time Complexity: 
        // Expected Auxiliary Space: O(1).
        public static void CyclicSortAscending(int[] arr)
        {


            int i = 0;
            while (i < arr.Length)
            {
                int correct = arr[i] - 1;
                if (arr[i] != arr[correct])
                {
                    swap(arr, i, correct);
                }
                else
                {
                    i++;
                }
            }
        }

        // Expected Time Complexity: 
        // Expected Auxiliary Space: 
        public static void CyclicSortDescending(int[] arr)
        {
           

            
        }

        static void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cyclic Sort Demo");
            //unsorted Array
            int[] arr = new int[5] { 4, 5, 1, 2, 3 };
            Console.WriteLine("Array before sorted");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            CyclicSortAscending(arr);
            Console.WriteLine("Array after sorted in ascending");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            CyclicSortDescending(arr);
            Console.WriteLine("Array after sorted in descending");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
