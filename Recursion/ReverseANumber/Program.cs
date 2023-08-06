namespace ReverseANumber
{
    internal class Program
    {
        public static int sum = 0;
        public static void ReverseANumberUsingRecursion(int n)
        {
            if (n == 0)
            {
                return;
            }

            int rem = n % 10;
            sum = sum * 10 + rem;
            ReverseANumberUsingRecursion(n / 10);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Reverse A Number Using Recursion");
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine()); // 1342
            ReverseANumberUsingRecursion(n);
            Console.WriteLine("Number After Reverse"); //Output 2431
            Console.WriteLine(Program.sum);
            Console.ReadLine();
        }
    }
}