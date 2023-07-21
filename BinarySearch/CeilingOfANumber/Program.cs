using System;

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

        public static int CeilingOfANumberByBinarySearchApproach2(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int result = -1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    result = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Celiling of a number using Binary Search");
            int[] arr = new int[7] { 2, 3, 5, 9, 14, 16, 18 };
            int target = 4;
            var output=  CeilingOfANumberByBinarySearch(arr, target);
            Console.WriteLine("index of Celiling of  a number is "+ output); //5 is the largest number then 4 so ans is index 2

            var output2 = CeilingOfANumberByBinarySearchApproach2(arr, target);
            Console.WriteLine("index of Celiling of  a number is " + output2); //5 is the largest number then 4  ans is index 2

            Console.ReadLine();

        }
    }
}
