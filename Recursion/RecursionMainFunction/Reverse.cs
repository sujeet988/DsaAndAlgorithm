using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMainFunction
{
    internal class Reverse
    {

       public static int sum = 0;
        public static void rev1(int n)
        {
            if (n == 0)
            {
                return;
            }

            int rem = n % 10;
            sum = sum * 10 + rem;
            rev1(n / 10);
        }

        public static int rev2(int n)
        {
            int digit = (int)(Math.Log10(n) + 1);
            return helper(n, digit);
        }
        private static int helper(int n, int digits)
        {
            if (n % 10 == n)
            {
                return n;
            }


            return 10;

        }
    }
}
