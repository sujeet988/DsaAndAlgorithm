using System;

namespace DivideArrayDynamicPrint
{
    internal class Program
    {
        /* Print array in 3 length.
         * 10 20 30
         * 40 50 60
         * 70
         */

        public static void arraySplit(int[] arr,int maxlimit)
        {
            int count = 1;
            for(int i=0; count <= maxlimit && i < arr.Length;i++)
            {
                if (count == maxlimit)
                {
                    Console.Write(arr[i]+" ");
                    count =1;
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(arr[i] + " ");
                    count++;
                }
               
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Divide Array Demo");
            int[] arr=new int[7] { 10,20,30,40,50,60,70};
            arraySplit(arr, 2);
            Console.ReadLine();
        }
    }
}
