using System;

namespace SetMatrixZero
{
    /*
     * Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
     * https://takeuforward.org/data-structure/set-matrix-zero/
     * https://leetcode.com/problems/set-matrix-zeroes/
     * https://practice.geeksforgeeks.org/problems/make-zeroes4042/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=make-zeroes
     */
    internal class Program
    {

        public void SetZeroes1(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;

            bool[] row_array = new bool[row];
            Array.Fill(row_array, true);

            bool[] col_array = new bool[col];
            Array.Fill(col_array, true);

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        row_array[i] = false;
                        col_array[j] = false;
                    }

                }
            }

            for (int i = 0; i < row; i++)
            {
                if (row_array[i] == false)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrix[i][j] = 0;
                    }

                }
            }


            for (int i = 0; i < col; i++)
            {
                if (col_array[i] == false)
                {
                    for (int j = 0; j < row; j++)
                    {
                        matrix[j][i] = 0;
                    }

                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Set Matric zero");
            Console.ReadLine();
        }
    }
}
