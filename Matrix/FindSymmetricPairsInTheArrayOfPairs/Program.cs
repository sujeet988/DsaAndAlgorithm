using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace FindSymmetricPairsInTheArrayOfPairs
{
    internal class Program
    {



        /*
        * Example 1:
        Input: (1,2),(2,1),(3,4),(4,5),(5,4)
        Output: (2,1) (5,4)
        Explanation: Since (1,2) and (2,1) are symmetric pairs and (4,5) and (5,4) are symmetric pairs.

        Example 2:
        Input: (1,5),(2,3),(4,2),(5,1),(2,4)
        Output: (2,4) (5,1)
        Explanation: Since (1,5) and (2,4) are symmetric pairs and (5,1) and (4,2) are symmetric pairs.
         * //Solution 1: Brute force
         * Intuition: For every pair check in the vector pair if the symmetric pair is present or not.
        Approach:

        First use a for loop and traverse through every pair in the vector.
        Then use another for loop and check if the symmetric pair of that pair is present in the rest of the vector or not.
        If the symmetric pair is present print the pair and break from the second for loop.so as to avoid repetitive printing of answers in case of duplicate pair.
        If the symmetric pair is not present, move to the next pair.

        */
        public static void PrintSyymmetricPair(int[,] array2d)
        {
            // array2d.GetLength(0) --return the rows of the array in two dimensional

            for ( int i=0; i < array2d.GetLength(0); i++ )
            {

                for (int j = i + 1; j < array2d.GetLength(0); j++)
                {

                    if (array2d[j, 0] == array2d[i, 1] && array2d[j, 1] == array2d[i, 0])
                    {
                        Console.Write("(" + array2d[i, 1] + " " + array2d[i, 0] + ")" + " ");
                        break;

                    }
                }
               
            }

        }

        static void Main(string[] args)
        {
            int[,] array2d = new int[5,2] { { 1, 2}, { 2, 1}, { 3, 4}, { 4, 5}, { 5, 4} };

            Console.WriteLine("The symmetric pairs are: ");
            PrintSyymmetricPair(array2d);
            Console.ReadLine();
        }
    }
}