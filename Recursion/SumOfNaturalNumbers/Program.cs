namespace DsaAndAlgorithm.Recursion.SumOfNaturalNumbers
{
    internal class Program
    {
        /*
         * Natural numbers are counting numbers that start from 1
         */

        public static int SumOfNaturalNumbersWithoutRecursion(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;

        }
        public static int SumOfNaturalNumbersWithRecursion(int n)
        {
            if (n == 0)
            {
                return n;
            }
            return n + SumOfNaturalNumbersWithRecursion(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Natural Numbers With Recursion");
            int n = 5;
            Console.WriteLine(SumOfNaturalNumbersWithRecursion(n)); // Output 15
            Console.WriteLine("Sum Of Natural Numbers WithOut Recursion");
            Console.WriteLine(SumOfNaturalNumbersWithoutRecursion(n)); // Output 15
            Console.ReadLine();


        }
    }
}