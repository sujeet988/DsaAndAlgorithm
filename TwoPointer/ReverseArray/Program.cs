using System;

namespace DsaAndAlgorithm.TwoPointer.ReverseArray
{
    internal class Program
    {
        // O(n) Time Compelexity
        // O(1) Time Complexity
        public static int[] ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                //swap last element with first
                int temp= arr[end];
                arr[end]= arr[start];
                arr[start]= temp;
                start++;
                end--;
            }
            return arr;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Array Demo");
            int[] arr = new int[5] { 100, 10, 30, 50, 60 };
            var reverseArray= ReverseArray(arr); // output : 60 50 30 10 100
            foreach(var item in reverseArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
