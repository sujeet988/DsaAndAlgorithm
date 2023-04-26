using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MathsDemo
{
    public class MathSk
    {
        //Count digits in a number
        //Given an integer N , write program to count number of digits in N.
        public static int count_digits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Given a number N reverse the number and print it.
        /// </summary>
        /// <param name="n">nunber int </param>
        /// <returns>int</returns>
        public static int reverse_A_Numbers(int n)
        {
            int reverse = 0;
            while (n > 0)
            {
                int modulus = n % 10;
                reverse = reverse * 10 + modulus;
                n = n / 10;
            }
            return reverse;
        }
        //Check if a number is Palindrome or Not
        public static bool isPalindrome(int n)
        {
            int x = n;
            int reverse = 0;
            while (x > 0)
            {
                int modulus = x % 10;
                reverse = reverse * 10 + modulus;
                x = x / 10;
            }
            if (n == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //print factorial of a number
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = n; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        //print factorial of a number uisng recusrion 
        public static int Factorialrecusrion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorialrecusrion(n - 1);
        }

        //Check if a number is prime or not
        //Given a number, check whether it is prime or not.A prime number is a natural number that is only divisible by 1 and by itself.
        //Examples 1 2 3 5 7 11 13 17 19 …
        // 1 is not a prime number
        public static bool isPrime(int N)
        {
            if (N <= 1)
            {
                return false;
            }

            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /*
         *Time Complexity: O(n) Space Complexity: O(1)
         */

        /*Using a for loop for checking if the number is divisible by a number from 2 to its square root.
            Running the for loop from 2 to the square root of the number.And then checking if the number is divisible by the numbers from 2 to its square root.
            Then, If the remainder is zero, that means it is divisible and hence not a prime number.
            If the loop runs till square root and none of the numbers divided it completely. So it is the Prime number.
         */
        public static bool isPrimeOptimized(int N)
        {
            if (N <= 1)
            {
                return false;
            }

           // Approach 1
            //for (int i = 2; i < Math.Sqrt(N); i++)
            //{
            //    if (N % i == 0)
            //    {
            //        return false;
            //    }
            //}
            //return true;

            //Approach 2 
            for (int i = 2; i*i<=N ; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Time Complexity: O(√n) Space Complexity: O(1)


        /*
         Armstrong Numbers are the numbers having the sum of digits raised to power no. of digits is equal to a given number. Examples- 0, 1, 153, 370, 371, 407, and 1634 are some of the Armstrong Numbers.
        153- 1*3+5*5*5+3*3*3=1532
         */

        public static bool ArmstrongNumber(int n)
        {
            int originalno = n;
            int count = 0;
            int temp = n;
            while (temp != 0)
            {
                count++;
                temp = temp / 10;
            }
            double sumofpower = 0;
            while (n != 0)
            {
                int digit = n % 10;
               sumofpower += Math.Pow(digit, count);
                n /= 10;
            }
            return (sumofpower == originalno);
        }
        //return all prime number less than n
        public static int  SieveOfEratosthenes(int n)
        {
            // Create a boolean array 
            // "prime[0..n]" and
            // initialize all entries
            // it as true. A value in
            // prime[i] will finally be 
            // false if i is Not a
            // prime, else true.
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                // If prime[i] is not changed,
                // then it is a prime
                if (prime[i])
                {
                    count++;
                    // Update all multiples of i
                    for (int j = 2 * i; j < n; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }


            return count;
        }
        /// <summary>
        /// Time Complexity: O(n* log(log(n)))
        ///  Auxiliary Space: O(n) 
        /// </summary>
  
         public static void PrintAllOfaDivisorOptimal(int n)
        {
            for(int i =1;i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
                if(i != n / i)
                {
                    Console.Write(n/i + " ");
                }
            }
        }


    }
}
