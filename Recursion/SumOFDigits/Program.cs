namespace DsaAndAlgorithm.Recursion.SumOFDigits
{
    internal class Program
    {
        public static int SumOfDigitUsingRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return (n % 10) + SumOfDigitUsingRecursion(n / 10);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Digit Using Recursion");
            int n = 54;
            Console.WriteLine(SumOfDigitUsingRecursion(n)); // Output 9
            Console.ReadLine();
        }
    }
}