using System;
using System.Linq;

namespace MoveZeroToEnd
{


    internal class Program
    {
        /*
         Input :  arr[] = {1, 2, 0, 4, 3, 0, 5, 0};
         Output : arr[] = {1, 2, 4, 3, 5, 0, 0, 0};
       */

        public static int[] MoverZeroToEndByLoop(int[] arr)
        {
            int count = 0;
            int[] newarr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newarr[count++] = arr[i];
                }

            }

            while (count < arr.Length)
            {
                arr[count] = 0;
                count++;
            }
            return newarr;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("MoveZeroToEnd");
            int[] arr = new int[] { 1, 2, 0, 4, 3, 0, 5, 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            //After shifting zeroes to end
            var outputarray = MoverZeroToEndByLoop(arr);

            for (int i = 0; i < outputarray.Length; i++)
            {
                Console.Write(outputarray[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
