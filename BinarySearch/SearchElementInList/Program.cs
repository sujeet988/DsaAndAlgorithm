namespace DsaAndAlgorithm.BinarySearch.SearchElementInList
{
    internal class Program
    {
        /*
         * https://practice.geeksforgeeks.org/problems/binary-search-1587115620/1
         * Given a sorted array of size N and an integer K, find the position(0-based indexing) at 
         * which K is present in the array using binary search.
         * Input:
            N = 5
            arr[] = {1 2 3 4 5} 
            K = 4
            Output: 3
            Explanation: 4 appears at index 3.
         */

        // time complexity : O(logn)
        public static int binarysearch(int[] arr, int n)
        {
            int start = 0;
            int end = arr.Length-1;
            while (start <= end)
            {
                // Both are correct for get mid  element
               // int mid = (start + end)/2;
                int mid=start+ (end - start)/2;
                if (arr[mid] == n)
                {
                    // if found return index;
                    return mid;
                }
                if(n > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            // if element not found return -1
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Search Element using Binary Search");
            int[] arr = new int[] { 12, 15, 18, 25, 36 };
            Console.WriteLine("Enter Element To Search");
            int n = Convert.ToInt32(Console.ReadLine()); //18
            var output= binarysearch(arr, n);
            Console.WriteLine(output); //2 18 is present at index 2
            Console.ReadLine();
        }
    }
}