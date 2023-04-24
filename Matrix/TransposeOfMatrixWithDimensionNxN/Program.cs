using System;
using System.Collections.Generic;

namespace TransposeOfMatrixWithDimensionNxN
{

    /*
     * https://www.youtube.com/watch?v=pqDZdKd1uLQ&t=42s ///pep coding
     * https://practice.geeksforgeeks.org/problems/transpose-of-matrix-1587115621/1
     * https://www.youtube.com/watch?v=n3-XWx-Inns&t=582s //hello worlds
     */
    internal class Program
    {

        //Function to display transpose of a matrix using swaping.
        //square matrix --row and colums length is same(n*n)
        public static void transposeusingswapping(List<List<int>> matrix)
        {
            int n = matrix.Count;
            //Transpose logic
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    // only one pair swap 
                    //swap  either lower or upper traingle
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }

            }

            //for print only
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Transpose Of Matrix With Dimension N x N ");

            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int> { 45, 48, 54 });
            matrix.Add(new List<int> { 21, 89, 87 });
            matrix.Add(new List<int> { 70, 78, 15 });

            Console.WriteLine("before transpose");
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("After Transpose");
            transposeusingswapping(matrix);
            Console.ReadLine();
        }
    }
}
