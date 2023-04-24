using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMainFunction
{
    internal class SumOfNNumbers
    {
       

        public static int SumofNusingFormula(int n)
        {
            int aa = 1 / 10;
            int bb = 1 % 10;
            return (n * (n + 1) / 2);
        }
        public static int SumofN(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + SumofN(n - 1);
        }
    }
}
