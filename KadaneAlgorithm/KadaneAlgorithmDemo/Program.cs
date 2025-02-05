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


        // using prefix sum
        // tc: o(n)
        public static int MaxSubArrayusingPrefixsum(int[] nums)
        {


            int max = nums[0];
            int len = nums.Length;

            int[] arrmax = new int[len];
            arrmax[0] = nums[0];

            for (int i = 1; i < len; i++)
            {
                arrmax[i] = Math.Max(arrmax[i - 1] + nums[i], nums[i]);
                max = Math.Max(arrmax[i], max);

            }


            return max;
        }

        /// <summary>
        /// BruteForce Approach tc: o(n2)
        /// </summary>
        /// <param name="nums">Array</param>
        /// <returns>int</returns>
        public static int MaxSubArrayBruteForce(int[] nums)
        {
            int n = nums.Length;
            int max = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {

                int sum = 0;

                for (int j = i; j < n; j++)
                {
                    sum += nums[j];
                    if (sum > max)
                    {
                        max = sum;
                    }
                }

            }
            return max;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("using Kadane Algorithm");
            // T.C : O(N)
            int[] arr = new int[5] { 1, 2, 3, -2, 5 };
            int result = MaxSubArrayKadaneAlgorithm(arr);
            Console.WriteLine(result); // 9
            // using brute force approach
            // using brute force O(n2)
            int resultusingbruteforce = MaxSubArrayBruteForce(arr);
            Console.WriteLine(resultusingbruteforce); // ans is 9

            // using prefix max sum
            // tc o(n)
            int resultusingprefixsum = MaxSubArrayusingPrefixsum(arr);
            Console.WriteLine(resultusingbruteforce); // ans is 9

            Console.ReadLine();
        }
    }
}