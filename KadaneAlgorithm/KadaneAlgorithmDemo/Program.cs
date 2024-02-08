namespace KadaneAlgorithmDemo
{
    /*
     Given an array Arr[] of N integers. 
    Find the contiguous sub-array(containing at least one number) which has the maximum sum and return its sum.
    Example 1:
    Input:
    N = 5
    Arr[] = {1,2,3,-2,5}
    Output:
    9
    Explanation:
    Max subarray sum is 9
    of elements (1, 2, 3, -2, 5) which 
    is a contiguous subarray.

    Example 2:

    Input:
    N = 4
    Arr[] = {-1,-2,-3,-4}
    Output:
    -1
    Explanation:
    Max subarray sum is -1 
    of element (-1)
     
     */
    internal class Program
    {
        /// <summary>
        /// KadaneAlgorithm
        /// </summary>
        /// <param name="nums">Array</param>
        /// <returns>int</returns>
        public static int MaxSubArrayKadaneAlgorithm(int[] nums)
        {
            int currentsum = nums[0];
            int overallsum = nums[0];
            int n = nums.Length;

            for (int i = 1; i < n; i++)
            {
                if (currentsum >= 0) // if previous sum coming positive value then append else start new flow
                {
                    currentsum += nums[i];
                }
                else
                {
                    currentsum = nums[i]; // assigning new value again 
                    // subarray with a sum less than 0 will always reduce our answer and so this type of subarray cannot be a part of the subarray with maximum sum.
                }
                if (currentsum > overallsum) //check current sum vs overllall sum
                {
                    overallsum = currentsum;
                }

            }
            return overallsum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kadane Algorithm");
            int[] arr = new int[5] { 1, 2, 3, -2, 5 };
            int result = MaxSubArrayKadaneAlgorithm(arr);
            Console.WriteLine(result); // 9
            Console.ReadLine();
        }
    }
}