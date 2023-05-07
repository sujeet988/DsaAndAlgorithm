using System;

namespace LcmOfNumbers
{
    /*
     * LCM stands for "Least Common Multiple", which is the smallest positive integer that is 
     * divisible by two or more integers without a remainder
     */
    public class Program
    {
        /*
        This method takes two integers a and b as input and returns their LCM.The gcd method is a 
        helper method that returns the GCD of the two numbers using the Euclidean algorithm.
        The lcm method simply returns the product of a and b divided by their GCD.

        */
        static int Lcm(int a, int b)
        {
            return a * b / GcdByEuclideanAlgorithm(a, b);
        }

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
            Console.WriteLine("Lcm Demo of two number");
            int num1 = 6;
            int num2 = 15;
            int lcm = Lcm(num1, num2);
            Console.WriteLine($"The LCM of {num1} and {num2} is {lcm}"); //answer is 30
            Console.ReadLine();
        }
    }
}
