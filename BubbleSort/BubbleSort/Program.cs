using System;

namespace BubbleSort
{
    /*
     * Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order.
     */
    internal class Program
    {
        public static void BubbleSortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j]; 
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

        }

        // Expected Time Complexity: O(N^2).
        // Expected Auxiliary Space: O(1).

        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort Demo");
            //unsorted Array
            int[] arr = new int[5] { 10, 50, 40, 30, 20 };
            Console.WriteLine("Array before sorted");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            BubbleSortArray(arr);
            Console.WriteLine("Array after sorted");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }


    }
}
