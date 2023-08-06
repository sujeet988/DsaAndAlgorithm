namespace DsaAndAlgorithm.Recursion.ProductOfDigits
{
    internal class Program
    {
        public static int ProductOfDigitsUsingRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return (n % 10) * ProductOfDigitsUsingRecursion(n / 10);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Product Of Digits Using Recursion");
            int n = 54;
            Console.WriteLine(ProductOfDigitsUsingRecursion(n)); // Output 20
            Console.ReadLine();
        }
    }
}