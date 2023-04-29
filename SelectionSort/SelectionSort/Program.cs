using System;

namespace SelectionSort
{
    /*
     *Selection sort -> select the greatest/lowest element and put it on right index
     */
    internal class Program
    {

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
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
            SelectionSort(arr);
            Console.WriteLine("Array after sorted");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
