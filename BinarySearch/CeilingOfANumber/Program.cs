using System;

namespace CeilingOfANumber
{
    internal class Program
    {

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
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling Of A Number");
            int[] arr = new int[7] { 2, 3, 5, 9, 14, 16, 18 };
            int target = 4;
            var output=  CeilingOfANumberByBinarySearch(arr, target);
            Console.WriteLine("Celiling of  a number is "+ output); //3
            Console.ReadLine();

        }
    }
}
