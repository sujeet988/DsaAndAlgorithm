using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMainFunction
{
    internal class SumOfNaturalNumbers
    {

        public static void SumOfNaturalNumbersWithoutRecursion()
        {
            int sum=0;
            for(int i = 1; i <= 5; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }


        public static int SumOfNaturalNumbersWithRecursion(int n)
        {
            if (n == 0) 
            {
                return n; 
            }

           
           return SumOfNaturalNumbersWithRecursion(n ) + SumOfNaturalNumbersWithRecursion(n - 1);
           
        }
    }
}
