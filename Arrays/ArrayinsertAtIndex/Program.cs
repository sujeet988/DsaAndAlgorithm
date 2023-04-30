using System;

namespace ArrayinsertAtIndex
{
    /*
     * Array insert at index
     * https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Arrays/problem/array-insert-at-index
     */
    internal class Program
    {

        //Complete this function
        // O(n)
        public static void insertAtIndex(int[] arr, int sizeOfArray, int index, int element)
        {
            //Your code here
            // Shift All  Element to right for given index and the  after loop places element at index.
            for (int i = sizeOfArray - 2; i >= index; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[index] = element;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Arrays insert At Index");
            int[] arr = new int[6];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            //Before insert
            Console.WriteLine("Before insert");
             foreach(int item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("after insert");
            int index = 5;
            int sizeOfArray=arr.Length;
            int element = 90;
            insertAtIndex(arr, sizeOfArray, index, element); //ouput : 1 2 3 4 5 90
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();


        }
    }
}
