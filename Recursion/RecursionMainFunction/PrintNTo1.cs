using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaAndAlgorithm.Recursion.RecursionMainFunction
{

    public class PrintNTo1
    {
        public static void DisplayNto1(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(n);

            DisplayNto1(n - 1);
        }

        public static void Display1toN(int n)
        {
            if (n == 0)
            {
                return;
            }
            Display1toN(n - 1);
            Console.WriteLine(n);
        }


    }


}
