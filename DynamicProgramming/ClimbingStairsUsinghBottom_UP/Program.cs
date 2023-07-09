namespace DsaAndAlgorithm.DynamicProgramming.ClimbingStairsUsinghBottom_UP
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
        public static int ClimbStairsUsing_Dp_Bottom_Up(int n)
        {
            //base cases
            if (n <= 2)
            {
                return n;
            }
            // Create a table to store steps 
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            // Return the the no of steps
            return dp[n];
        }

        static void Main(string[] args)
        {
            //using recursion
            Console.WriteLine("Climb Stairs Using dp bottom up approach");
            //Enter the number of stairs:
            int n = 5;
            var ways = ClimbStairsUsing_Dp_Bottom_Up(n);
            Console.WriteLine("Number of distinct ways to climb the stairs: " + ways); // output : 8
            Console.ReadLine();
        }
    }
}