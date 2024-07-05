using System;

namespace PrefixSum
{
    /*
     *  PreFixSum
     *  https://www.geeksforgeeks.org/prefix-sum-array-implementation-applications-competitive-programming/
     */

    internal class Program
    {
        // Time complexity : o(n)
        public static int[] PreFixSum(int[] arr)
        {
            int n=arr.Length;
            int[] output= new int[n];
            output[0] = arr[0]; // first value
            for(int i=1; i < n; i++)
            {
                int prefixsum = output[i-1]+arr[i];
                output[i]=prefixsum;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Prefix Sum Demo");
            int[] arr = new int[5] { 1,2,3,4,5 };
            Console.WriteLine("before Prefix Sum"); //1,2,3,4,5
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            var output = PreFixSum(arr); //ss
            Console.WriteLine("After Prefix Sum"); // 1 3 6 10 15
            foreach (var item in output)
            {
                Console.Write(item+" ");
            }

            Console.ReadLine();


        }
    }
}
