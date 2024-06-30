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

        public static void SetZeroes1(int[][] matrix)
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
                if (!row_array[i])
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrix[i][j] = 0;
                    }

                }
            }


            for (int i = 0; i < col; i++)
            {
                if (!col_array[i])
                {
                    for (int j = 0; j < row; j++)
                    {
                        matrix[j][i] = 0;
                    }

                }
            }

        }

        // optimal approach
        /*
         * Time Complexity: O(2*(N*M)), where N = no. of rows in the matrix and M = no. of columns in the matrix.
Reason: We are traversing the entire matrix 2 times and each traversal is taking O(N*M) time complexity.

Space Complexity: O(N) + O(M), where N = no. of rows in the matrix and M = no. of columns in the matrix.
Reason: O(N) is for using the row array and O(M) is for using the col array.
         */
        public static void SetZeroesoptimal(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;

            int[] rowarray = new int[row];
            int[] colarray = new int[col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowarray[i] = 1;
                        colarray[j] = 1;

                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (rowarray[i] == 1 || colarray[j] == 1)
                    {
                        matrix[i][j] = 0;

                    }
                }
            }





        }
        static void Main(string[] args)
        {
            Console.WriteLine("Set Matrix zero");
            int n = 3;
            const int m = 3;
            int[][] matrix = new int[n][];
            matrix[0] = new int[m] { 1, 1, 1 };
            matrix[1] = new int[m] { 1, 0, 1 };
            matrix[2] = new int[m] { 1, 1, 1 };
            // print matrix

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }

            // set matrix zero aprpoach 1
            // SetZeroes1(matrix);
            //approach 2
            SetZeroesoptimal(matrix);
            Console.WriteLine("Matrix after inplace changed to zero");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
