namespace DsaAndAlgorithm.BinarySearch.FloorOfanElementInaSortedArray
{
    internal class Program
    {
        /*
         * https://practice.geeksforgeeks.org/problems/floor-in-a-sorted-array-1587115620/1
         * Given a sorted array arr[] of size N without duplicates, and given a value x. 
         * Floor of x is defined as the largest element K in arr[] such that K is smaller than 
         * or equal to x. Find the index of K(0-based indexing).
         * 
         * Input:
            N = 7, x = 5 
            arr[] = {1,2,8,10,11,12,19}
            Output: 1
            Explanation: Largest Number less than 5 is
            2 (i.e K = 2), whose index is 1(0-based 
            indexing).

        Input : 
        N = 7, x = 0 
        arr[] = {1,2,8,10,11,12,19}
        Output: -1
        Explanation: No element less 
        than 0 is found. So output 
        is "-1".

        Floor : Note : Greatest Element smaller than given number N=7
         */

        // Find Floor using Linear Search o(n)
        public static int findFloorUsingLinearSearch(int[] arr, int n, int x)
        {
            //code here
            int result = -1;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= x)
                {
                    result = i;

                }
            }

            return result;
        }

        // Find Floor using Binary Search o(logn)
        public int findFloorUsingBinarySearch(int[] arr, int n, int x)
        {
            //code here
            int start = 0;
            int end = n - 1;
            int result = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if(x > arr[mid])
                {
                    result = mid; //before move to righ side , store value  in result
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" index of Floor of a number using Linear Search");
            int[] arr = { 1, 2, 8, 10, 11, 12, 19 };
            int n = 7;
            int x = 5;
            int output = findFloorUsingLinearSearch(arr, n, x);
            Console.WriteLine(output); // ouput : 1
            Console.WriteLine("Floor of a number using Binary Search");
            int output1 = findFloorUsingLinearSearch(arr, n, x);
            Console.WriteLine(output1);// ouput : -1
            Console.ReadLine();
        }
    }
}