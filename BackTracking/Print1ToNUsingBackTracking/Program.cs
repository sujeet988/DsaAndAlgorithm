namespace DsaAndAlgorithm.BackTracking.Print1ToNUsingBackTracking
{
    internal class Program
    {
        /*
         * https://www.linkedin.com/posts/shubham-upadhyay1_striver-recursion-notes-activity-7045627239131942912-AIRG/
         */

        static void Print1ToN(int n)
        {
            if (n == 0)
            {
                return;
            }

            Print1ToN(n - 1);
            Console.WriteLine(n);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Print 1 To N using Backtracking ");
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            Print1ToN(n);
            Console.ReadLine();
        }
    }
}