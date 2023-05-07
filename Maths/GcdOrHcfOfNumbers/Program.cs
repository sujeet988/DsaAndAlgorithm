using System;

namespace GcdOrHcfOfNumbers
{
    /*
     * https://leetcode.com/problems/find-greatest-common-divisor-of-array/description/
     * The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
     */
    internal class Program
    {

        public static int GcdByEuclideanAlgorithm(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GcdByEuclideanAlgorithm(b, a % b);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Gcd or Hcf by Euclidean algorithm ");
            int a = 24;
            int b = 36;
            int gcdoutput = GcdByEuclideanAlgorithm(a, b);
            Console.WriteLine("GCD of " + a + " and " + b + " is " + gcdoutput); //Ans is 12
            Console.ReadLine();

        }
    }
}
