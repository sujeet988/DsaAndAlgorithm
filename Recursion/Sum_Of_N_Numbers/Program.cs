namespace DsaAndAlgorithm.Recursion.Sum_Of_N_Numbers
{
    internal class Program
    {
        public static int SumofNNumberUsingFormula(int n)
        {
            int aa = 1 / 10;
            int bb = 1 % 10;
            return (n * (n + 1) / 2);
        }
        public static int SumofNNumberUsingRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + SumofNNumberUsingRecursion(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of N number Using Recrusion");
            int n = 5;
            Console.WriteLine(SumofNNumberUsingRecursion(n)); // output 10 ->   4+3+2+1+0=10
            Console.WriteLine("Sum Of N number Using Formula"); 
            Console.WriteLine(SumofNNumberUsingFormula(n)); // output 10->   4+3+2+1+0=10
            Console.ReadLine();
        }
    }
}