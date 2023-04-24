using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SumOfElementsInAMatrix
{
    /*
     * Sum of elements in a matrix
     * https://practice.geeksforgeeks.org/problems/sum-of-elements-in-a-matrix2000/1
     * Given a non null integer matrix Grid of dimensions NxM.Calculate the sum of its elements.
     * Input:
        N=2,M=3
        Grid=
        [[1,0,1],
        [-8,9,-2]]
        Output:
        1
     */
    internal class Program
    {
        //Sum of elements in a matrix
        public static int sumOfMatrix(int[][] Grid)
        {
            int sum = 0;
            for(int row=0; row< Grid.Length; row++)
            {
                for(int col=0; col < Grid[row].Length; col++)
                {
                        sum+= Grid[row][col];
                }
            }
            return sum;
         }

        static void Main(string[] args)
        {
            Console.WriteLine(" Sum of elements in matrix");

            int[][] grid = new int[2][] { new int[] { 1, 0, 1 }, new int[] { -8, 9, -2 } };
            var sum = sumOfMatrix(grid);
            Console.WriteLine(sum); //output 1
            Console.ReadLine();
        }
    }
}
