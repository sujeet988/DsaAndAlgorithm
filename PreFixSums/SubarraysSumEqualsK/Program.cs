namespace SubarraysSumEqualsK
{
    /*
     * https://leetcode.com/problems/subarray-sum-equals-k/description/s
        * Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
        A subarray is a contiguous non-empty sequence of elements within an array.
        Example 1:

        Input: nums = [1,1,1], k = 2
        Output: 2
        Example 2:

        Input: nums = [1,2,3], k = 3
        Output: 2
     */
    internal class Program
    {
        public static int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            hash.Add(0, 1); // for first comparison
            int count = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                int temp = sum - k;

                if (hash.ContainsKey(temp)) // if key already exists add in the array
                {
                    count += hash[temp];
                }

                if (hash.ContainsKey(sum)) // update count of existing sum
                {
                    hash[sum]++;
                }
                else
                {
                    hash[sum] = 1; // if sum alredy not exists then increase by 1
                }

            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Subarray Sum Equals K");
            int[] arr = new int[] { 1, 1, 1 };
            int k = 2;
            int count = SubarraySum(arr, k);
            Console.WriteLine(count); // ans is 2
            Console.ReadLine();
        }
    }
}