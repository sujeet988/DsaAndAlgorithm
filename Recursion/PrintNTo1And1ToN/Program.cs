namespace DsaAndAlgorithm.Recursion.PrintNTo1And1ToN
{
    internal class Program
    {
        public static void DisplayNto1(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.Write(n + " ");

            DisplayNto1(n - 1);
        }

        public static void Display1toN(int n)
        {
            if (n == 0)
            {
                return;
            }
            Display1toN(n - 1);
            Console.Write(n+" ");
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Enter Number");
             int n=Convert.ToInt32(Console.ReadLine()); // n==5
             Console.WriteLine("Print N to 1");
             DisplayNto1(n); // Output : 5 4 3 2 1
             Console.WriteLine();
             Console.WriteLine("Print 1 To N");
             Display1toN(n); // Output : 1 2 3 4 5
             Console.ReadLine();
        }
    }
}