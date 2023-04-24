using System;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace BitWiseQuestions
{


    public class BitWiseAllquestins
    {

            public static void GetithBit(int n, int k)
            {
                int bitMask = 1 << k-1;// 4 
                                       //or
              if ((bitMask & n) == 0)
                {
                    Console.WriteLine ("bit was zero");
                }
                else
                {
                Console.WriteLine("bit was one");
                }
            }

           public static void SetBit(int n, int k)
            {
            Console.WriteLine("Set bit for number {0} for k th position{1}", n, k);
            int bitMask = 1 << k-1;
            int newNumber = bitMask | n;
            Console.WriteLine("New Number is : " +newNumber);
            }

        /// <summary>
        /// set 0 to 1 and 1 to 0 for kth bit
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void ClearBit(int n, int k)
        {
            Console.WriteLine("Set clear for number {0} for k th position{1}", n, k);
            int bitMask = 1 << k - 1;
            int newbitMask = ~(bitMask);
            int newNumber = newbitMask & n;
            Console.WriteLine("New Number is : " + newNumber);
        }

        /// <summary>
        /// set 1 to 0
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void updatebit(int n, int k, int operation)
        {
            int bitMask = 1 << k - 1;
            // operation=1 -> set to 1; operation=0 -> set 1 to 0 clear

            if (operation == 1)
            {
                //set
                int newNumber = bitMask | n;
                Console.WriteLine(newNumber);
            }
            else
            {
                //clear
                int newBitMask = ~(bitMask);
                int newNumber = newBitMask & n;
                Console.WriteLine(newNumber);
            }
        }
        public static bool iSOdd(int n)
        {
            if ((n & 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void  Swap(int a,int b)
        {
            //swaping with two number without using  third varaible
            //a = a - b;
            //b = b + a;
            //a = b - a;

            //using bit waise
            Console.WriteLine("value if a & b is {0} :{1} :", a, b);
            a =a ^ b;
            b=b ^ a;
            a=a ^ b;
            Console.WriteLine("value after swap  of a is  {0} and b :  {1} ", a, b);
        }

        public static void countsetbit(int n)
        {
            int count = 0;
            while (n > 0)
            {
                // The mask used (value of 1) with the bitwise AND examines the right most bit which
                // results in the value of either 0 or 1.
                if ((n & 1) == 1)
                    count++;

                // Move all bits to the right by 1 position.
                //  n >>= 1;
                n = n >> 1;
            }

            Console.WriteLine("number of set bit is: " + count);
        }

        public static void CheckIfKthBitIsSetOrnotusingleftShift(int n, int k)
        {
            bool iskth = false;
            //bit mask
            int x = (1 << k - 1);
            if ((n&x) != 0)
            {
                iskth = true;
            }
            else
            {
                iskth = false;
            }
            Console.WriteLine("i  kth  bit is set: " + iskth);
        }

        public static void CheckIfKthBitIsSetOrnotusingrightShift(int n, int k)
        {
            bool iskth = false;
            //bit mask
            int x = (n >> k - 1);
            if((x & 1) != 0)
            {
                iskth = true;
            }
            else
            {
                iskth=false;
            }
            Console.WriteLine("i  kth  bit is set: " + iskth);
        }
        public static void ispowerof2(int n)
        {
            /*
             if a number is power of two then only one set bit present 
             */

            bool ispowerof2 = false;
            if (n == 0)
            {
                ispowerof2 = false;
            }
            
            if((n & n - 1) == 0)
            {
                ispowerof2 = true;
            }

            Console.WriteLine("is {0} power of {1}",n,ispowerof2);
        }
        public static void OddOccuringElement(int[] arr)
        {
            int n=arr.Length;
            int result = 0; //

            for (int i=0; i < n; i++)
            {
                result = result ^ arr[i];
            }
            Console.WriteLine("odd occuring element "+result);
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD BIT
            int n = 5;
            int k = 3;

            BitWiseAllquestins.GetithBit(n,k);
            //set bit
            n = 5;
            k = 2;
            BitWiseAllquestins.SetBit(n,k);
            //clear bit 
            n = 5;
            k = 3;
            BitWiseAllquestins.ClearBit(n, k);

            //update bit  for set 
            n = 5;
            k = 2;
            int operation = 1;
            BitWiseAllquestins.updatebit(n, k, operation);

            //update bit  for clear 
            n = 5;
            k = 3;
            operation = 0;
            BitWiseAllquestins.updatebit(n, k, operation);

            //check even odd
            n = 7;
           var result= BitWiseAllquestins.iSOdd(n);
            if (result)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("Even");
            }

            //swap
            int a = 10;
            int b = 5;
            BitWiseAllquestins.Swap(a, b);

            //count setbit
            n = 6;
            BitWiseAllquestins.countsetbit(n);

            //  check kth bit is set or not using  left operator
            n = 5;
            k = 3;
            BitWiseAllquestins.CheckIfKthBitIsSetOrnotusingleftShift(n, k);

            //  check kth bit is set or not using  right operator
            n = 5;
            k = 3;
            BitWiseAllquestins.CheckIfKthBitIsSetOrnotusingrightShift(n,k);

            //check is number power of 2
            n= 7;
            BitWiseAllquestins.ispowerof2(n);

            //odd occuring element
            int[] arr= new int[9] {4,4,7,4,8,7,7,7,8}; // ans =4 it repeat with 3 times
            BitWiseAllquestins.OddOccuringElement(arr);
            Console.ReadLine();
        }
    }
}
