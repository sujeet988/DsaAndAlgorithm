using System;

namespace MathsDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Demo");
            int n = 1234;
            //Count Number of digits
            Console.WriteLine ("Number of digits in " + n + " is " + MathSk. count_digits(n));
            //reverse a number
            Console.WriteLine("Reverse of a number  " + n + " is " + MathSk.reverse_A_Numbers(n));
            //check given numbber is prime or not
             n = 121;
            Console.WriteLine("Number is palindrome " + n + " is " + MathSk.isPalindrome(n));

            //Factorial of a  number
            n = 5;
            Console.WriteLine("Factorail of number: " + n + ": is " + MathSk.Factorial(n));
            Console.WriteLine("Factorail of number: " + n + " is " + MathSk.Factorialrecusrion(n));

            //  Check  number is prime or not
            n = 13;
            Console.WriteLine("Given number : " + n + ": is prime " + MathSk.isPrime(n));

            //  Check  number is prime or not WITH BETTER APPORACH
            n = 23;
            Console.WriteLine("Given number : " + n + ": is prime " + MathSk.isPrimeOptimized(n));

            //ArmStrong number
             n = 153;
            if (MathSk.ArmstrongNumber(n))
            {
                Console.WriteLine("Yes, it is an Armstrong Number\n");
            }
            else
            {
                Console.WriteLine("No, it is not an Armstrong Number\n");
            }

            //Sieve of Eratosthenes
            n = 10;
            Console.WriteLine("number or prime number less than: " + n + ": is " + MathSk.SieveOfEratosthenes(n));


            //Print all disvisor of a number
            n = 36;
            MathSk.PrintAllOfaDivisorOptimal(n);

            Console.ReadLine();

        }
    }
}
