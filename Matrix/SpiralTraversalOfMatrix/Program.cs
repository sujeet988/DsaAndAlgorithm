using System;
using System.Collections.Generic;

namespace SpiralTraversalOfMatrix
{
    /*
     * Spiral of a matrix
     * https://practice.geeksforgeeks.org/problems/spirally-traversing-a-matrix-1587115621/1
     * https://takeuforward.org/data-structure/spiral-traversal-of-matrix/
     * 
     * Input:
        r = 4, c = 4
        matrix[][] = {{1, 2, 3, 4},
                   {5, 6, 7, 8},
                   {9, 10, 11, 12},
                   {13, 14, 15,16}}
        Output: 
        1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10
     */

    internal class Program
    {

        //Function to return a list of integers denoting spiral traversal of matrix.
        public static List<int> SpirallyTraverse(List<List<int>> matrix)
        {
            //code here
            List<int> result = new List<int>();
            int top = 0; // row top
            int bottom = matrix.Count - 1; // row bottom 
            int left = 0;
            int right = matrix[0].Count - 1;

            while (top <= bottom && left <= right)
            {
                // For moving top left to right
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }

                top++;

                // For moving right cloumn from top to bottom.

                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;
                // For moving right to left.
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }
                    bottom--;
                }
                // For moving bottom to top.
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }
                    left++;
                }


            }

            return result;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Spirally traversing a matrix");
            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int> { 1, 2, 3, 4 });
            matrix.Add(new List<int> { 5, 6, 7, 8 });
            matrix.Add(new List<int> { 9, 10, 11, 12 });
            matrix.Add(new List<int> { 13, 14, 15, 16 });

            Console.WriteLine("before Spirally Traverse");
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("After pirally Traverse ");
            List<int> output = null;
            output = Program.SpirallyTraverse(matrix);

            for (int i = 0; i < output.Count; i++)
            {

                Console.Write(output[i] + " ");
            }
            Console.ReadLine();


        }
    }
}
