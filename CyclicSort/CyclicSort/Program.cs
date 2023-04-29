using System;

namespace CyclicSort
{
    /*
     * Cyclic Sort
     */
    internal class Program
    { 
        
        // Expected Time Complexity: 
        // Expected Auxiliary Space: O(1).
        public static void CyclicSortAscending(int[] arr)
        {
           

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
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

        // Expected Time Complexity: 
        // Expected Auxiliary Space: 
        public static void CyclicSortDescending(int[] arr)
        {
           

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
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
