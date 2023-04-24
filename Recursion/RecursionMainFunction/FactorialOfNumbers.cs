using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMainFunction
{
    public class FactorialOfNumbers
    {
        public FactorialOfNumbers()
        {

        }

        public  static int factorial(int n)
        {
            if(n==1 || n== 0)
            {
                return 1;
            }
            int fact = 1;
            for(int i=n;  i >= 1; i--)
            {
                fact *= i;
            }

            return fact;
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

        public static int PrintFactorialusingreturn(int n)
        {
            if( n == 0|| n == 1)
            {
                return 1 ;
            }

            return n * PrintFactorialusingreturn(n - 1);
        }
    }
}
