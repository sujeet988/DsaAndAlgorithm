using System;
using System.Collections.Generic;

namespace HappyNumber
{
    /*
     *  A number is called happy if it leads to 1 after a sequence of steps wherein each step 
        number is replaced by the sum of squares of its digit that is if we start with Happy 
        Number and keep replacing it with digits square sum, we reach 1.
     *  Input: n = 19
        Output: True
        19 is Happy Number,
        1^2 + 9^2 = 82
        8^2 + 2^2 = 68
        6^2 + 8^2 = 100
        1^2 + 0^2 + 0^2 = 1
        As we reached to 1, 19 is a Happy Number.

        Input: n = 20
        Output: False
     
     */
    internal class Program
    {
        /*
         * The method uses a HashSet to keep track of the numbers seen during the process, in order 
         * to detect cycles. The method repeatedly calculates the sum of the squares of the digits 
         * of n until either 1 is reached (in which case n is a happy number) or a cycle is detected (in which case n is not a happy number).
         */
        static bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            while (n != 1)
            {
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n = n / 10;
                }

                if (seen.Contains(sum))
                {
                    return false;
                }

                seen.Add(sum);
                n = sum;
            }
                
            return true;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Happy Number Demo");
            int num = 19;
            bool isHappy = IsHappy(num);

            Console.WriteLine($"{num} is{(isHappy ? " " : " not ")}a happy number."); //return true
            num = 18;
            Console.WriteLine($"{num} is{(isHappy ? " " : " not ")}a happy number."); //return false;

            Console.ReadLine();
        }
    }
}
