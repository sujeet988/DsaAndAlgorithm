using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMainFunction
{
    internal class SumOFDigits
    {

        public static int SumOfDigitRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return (n%10) + SumOfDigitRecursion(n/10);

        }

        public static int ProdofDigits(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return (n % 10) * ProdofDigits(n / 10);

        }
    }
}
