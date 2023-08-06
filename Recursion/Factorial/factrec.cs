using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaAndAlgorithm.Recursion.Factorial
{
    public class FactorialDemo
    {

        public static int fact(int n)
        {
            int factreturn = 1;
            for (int i = n; i >= 1; i--)
            {
                factreturn *= i;
            }
            return factreturn;
        }

        public static int factusingrec(int n)
        {

            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * factusingrec(n - 1);
        }

        public static void printFactorialrecursion(int n, int fact)
        {
            if (n == 0)
            {
                Console.WriteLine(fact);
                return;
            }
            fact *= n;
            printFactorialrecursion(n - 1, fact);
        }
    }
}
