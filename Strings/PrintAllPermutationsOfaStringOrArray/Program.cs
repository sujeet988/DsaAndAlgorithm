using System;
using System.Collections.Generic;
using System.Linq;

namespace DsaAndAlgorithm.Strings.PrintAllPermutationsOfaStringOrArray
{
    /*
     * A permutation also called an “arrangement number” or “order,” is a rearrangement of the elements of an ordered list S into a one-to-one correspondence with S itself. A string of length N has N! permutations. 
     * if array length is n=3 then permutation of that array is n!(n factorial) -> 3*2 *1=6
     * if string  length is n=4 then permutation of that array is n!(n factorial) -> 4*3*2*1=24
     * Example : Input: S = “ABC” Output: “ABC”, “ACB”, “BAC”, “BCA”, “CBA”, “CAB”
     *  * Example : Input: S = “ABC” Output: “ABC”, “ACB”, “BAC”, “BCA”, “CBA”, “CAB”
     *  Input: arr = [1, 2, 3]
        Output: 
        [
          [1, 2, 3],
          [1, 3, 2],
          [2, 1, 3],
          [2, 3, 1],
          [3, 1, 2],
          [3, 2, 1]
        ]
     

     */

    internal class Program
    {
        public static void Permute(int[] arr, IList<IList<int>> result, int index)
        {
            //base case 
            if (index >= arr.Length)
            {
                result.Add(arr.ToList());
                return;
            }
         
            for(int j=index; j < arr.Length; j++)
            {
                Swap(arr,index,j);
                Permute(arr, result, index + 1);
                //backTrack
                Swap(arr, index, j);
            }

        }

        public static void Swap(int[] arr, int start, int end)
        {
            int temp = arr[end];
            arr[end] = arr[start];
            arr[start] = temp;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("permutation of array example!");
            int[] arr=new int[3] { 1,2,3};
            int index = 0;
            IList<IList<int>> result=new List<IList<int>>();
            Permute(arr,result,index);
            // Print Output
            foreach(var Ilist in result.ToList())
            {
                Console.Write("[");
                foreach( var item in Ilist )
                {
                   Console.Write(item);    
                }
                Console.Write("] ");
            }
            Console.ReadLine();


        }
    }
}
