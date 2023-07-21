﻿using System;

namespace DsaAndAlgorithm.BinarySearch.CeilingOfANumber
{
    internal class Program
    {
        
        // time Compexity O(logn)
        public static int CeilingOfANumberByBinarySearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while(start <= end)
            {
                int mid=(start+end)/2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if(target< arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Floor of a number using Binary Search");
            int[] arr = new int[7] { 2, 3, 5, 9, 14, 16, 18 };
            int target = 4;
            var output=  CeilingOfANumberByBinarySearch(arr, target);
            Console.WriteLine("Celiling of  a number is "+ output); //3 is the largest number that is less then target=4 element
            Console.ReadLine();

        }
    }
}
