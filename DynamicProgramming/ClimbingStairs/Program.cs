using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace DsaAndAlgorithm.DynamicProgramming.ClimbingStairs
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/climbing-stairs/
         * You are climbing a staircase. It takes n steps to reach the top.Each time you can 
         * either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
         * Input: n = 2
            Output: 2
            Explanation: There are two ways to climb to the top.
            1. 1 step + 1 step
            2. 2 steps
          Input: n = 3
            Output: 3
            Explanation: There are three ways to climb to the top.
            1. 1 step + 1 step + 1 step
            2. 1 step + 2 steps
            3. 2 steps + 1 step
         */

        // For large input it will give TLE(Time Limit exceed error) error
        public static int ClimbStairsUsingRecursion(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            return ClimbStairsUsingRecursion(n - 1) + ClimbStairsUsingRecursion(n - 2);
        }

        public static int ClimbStairsUsing_Dp_Memoization(int n, List<int> memo)
        {
            if (memo[n] != -1)
            {
                return memo[n];
            }

            if (n <= 2)
            {
                return memo[n]=n;
            }
            int result = ClimbStairsUsing_Dp_Memoization(n - 1, memo) + ClimbStairsUsing_Dp_Memoization(n - 2, memo);
            return memo[n]=result;
        }
        public static int ClimbStairsUsing_Dictionary_Dp_Memoization(int n, Dictionary<int,int> memo)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n <= 2)
            {
                return n;
            }
            int result = ClimbStairsUsing_Dictionary_Dp_Memoization(n - 1, memo) + ClimbStairsUsing_Dictionary_Dp_Memoization(n - 2, memo);
            return memo[n] = result;
        }
        static void Main(string[] args)
        {
            //using recursion
            Console.WriteLine("Climb Stairs Using Recursion");
            //Enter the number of stairs:
            int n = 5;
            var ways = ClimbStairsUsingRecursion(n);
            Console.WriteLine("Number of distinct ways to climb the stairs: "+ways); // output : 8

            // using Memoization/TopDown approach
            // create list of n+1 and intiliaze with -1 for default values
            List<int> memo=new List<int>();
            for(int i=0; i <= n; i++)
            {
                memo.Add(-1);
            }
            var resultusingdp= ClimbStairsUsing_Dp_Memoization(n, memo);
            Console.WriteLine("Number of distinct ways to climb the stairs using dp: " + resultusingdp); // output : 8

            // using Memoization/TopDown approach
            // create Dictionary
            Dictionary<int,int> memodict = new Dictionary<int,int>();
            var resultusingdpanddictionary = ClimbStairsUsing_Dictionary_Dp_Memoization(n, memodict);
            Console.WriteLine("Number of distinct ways to climb the stairs using dp: " + resultusingdpanddictionary); // output : 8

            Console.ReadLine();
        }
    }
}