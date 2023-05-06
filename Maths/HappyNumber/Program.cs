using System;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
