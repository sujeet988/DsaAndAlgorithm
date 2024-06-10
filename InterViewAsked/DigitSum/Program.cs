namespace DigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int n = Convert.ToInt32(Console.ReadLine());

            int sumofeven = 0;
            int oddsum = 0;
            while (n >= 1)
            {
                int temp = n % 10;
                if(temp%2==0)
                {
                    sumofeven+=temp;
                }
                else
                {
                    oddsum+= temp;   
                }
                n /= 10;
            }
            Console.WriteLine("Sum of Even Number is : -> "+ sumofeven);
            Console.WriteLine("Sum of Odd Number is : -> " + oddsum);
            Console.ReadLine();
        }
    }
}