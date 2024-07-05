using System.Reflection;

namespace DsaAndAlgorithm.DynamicProgramming.FibonacciSeriesUsingDp
{
    /*
     * 509-question number
     * https://leetcode.com/problems/fibonacci-number/description/
     */
    public class Program
    {
        /*
         * Fibonacci number : 0 1 1 2 3 5 8 13
         */
        public static int NthFibonacciNumberUsingRecursion(int n)
        {
            if (n <= 1)
            {
                // Base cases: Fib(0) = 0, Fib(1) = 1
                return n;
            }
            return NthFibonacciNumberUsingRecursion(n - 1) + NthFibonacciNumberUsingRecursion(n - 2);
        }

        //using Top Down Approach/ Memoization
        // we can use either list/array/dictionary
        public static int NthFibonacciNumberUsing_Dp_Memoization(int n, List<int> memo)
        {
            // If the value is already computed, return it from the memoization cache
            if (memo[n] != -1)
            {
                return memo[n];
            }

            if (n <= 1)
            {
                // Base cases: Fib(0) = 0, Fib(1) = 1
                return memo[n] = n;
            }

            // Compute Fib(n) by recursively computing Fib(n-1) and Fib(n-2)
            // Store the computed value in the memoization cache
            memo[n]= NthFibonacciNumberUsing_Dp_Memoization(n - 1, memo) + NthFibonacciNumberUsing_Dp_Memoization(n - 2, memo);
            return memo[n];
        }

        //using  bottom-up/Tabulation Approach
        public static int NthFibonacciNumberUsing_Dp_Bottom_Up(int n)
        {
            if (n <= 1)
            {
                // Base cases: Fib(0) = 0, Fib(1) = 1
                return n;
            }
            // Create a table to store Fibonacci numbers
            int[] arr=new int[n+1];
            arr[0]= 0;
            arr[1]= 1;

            // Compute Fibonacci numbers up to n using tabulation
            for (int i=2; i <= n; i++)
            {
                arr[i] = arr[i-1]+ arr[i-2];
            }

            // Return the Fibonacci number at index n
            return arr[n];
        }

        static void Main(string[] args)
        {
            //Using Recursion

            Console.WriteLine("Nth Fibonacci Number using Recursion");
            int n = 10;
            int outputRecursion = NthFibonacciNumberUsingRecursion(n);
            Console.WriteLine(outputRecursion);

            /////////////////Top Down/Memoization Approach
            Console.WriteLine("Nth Fibonacci Number using Dynamic Programming using Top Down/Memoization Approach ");
            List<int> memo = new List<int>();
            for(int i=0; i <= n; i++)
            {
                memo.Add(-1);
            }
            var outputDpMemo=NthFibonacciNumberUsing_Dp_Memoization(n,memo);
            Console.WriteLine(outputDpMemo);

            /////////////////Tabulation/Bottom-Up Approach
            Console.WriteLine("Nth Fibonacci Number using Dynamic Programming using Tabulation/Bottom-Up Approach ");
            int outputBottomup = NthFibonacciNumberUsing_Dp_Bottom_Up(n);
            Console.WriteLine(outputBottomup);
            
            Console.ReadLine();
        }
    }
}