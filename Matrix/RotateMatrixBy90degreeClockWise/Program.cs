using System;

namespace RotateMatrixBy90degreeClockWise
{
    /*
     * https://leetcode.com/problems/rotate-image/
     * https://www.youtube.com/watch?v=uB0RgD4p3LY&list=PL-Jc9J83PIiE-TR27GB7V5TBLQRT5RnSl&index=24
     * https://takeuforward.org/data-structure/rotate-image-by-90-degree/
     *  Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        Output: [[7,4,1],[8,5,2],[9,6,3]]
     */

    internal class Program
    {
        // rotate matrix by 90 degree clock wise
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            //Transpose and Reverse the array
            TransposeMatrix(matrix, n);
            ReverseRow(matrix, n);
        }

        private static void TransposeMatrix(int[][] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    //lower traingle transpose
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[col][row];
                    matrix[col][row] = temp;
                }
            }

        }

        private static void ReverseRow(int[][] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                int left = 0;
                int right = n - 1;
                while (left < right)
                {
                    int temp = matrix[row][left];
                    matrix[row][left] = matrix[row][right];
                    matrix[row][right] = temp;
                    left++;
                    right--;
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Rotate Image/matrix by 90 degree clock wise");
            int[][] matrix = new int[3][] { new int[] { 1,2,3}, new int[] { 4,5,6 }, new int[] { 7,8,9 } };
            Console.WriteLine("Matrix before rotation");
            for(int i=0; i < matrix.Length; i++)
            {
                 for(int j=0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+" ");
                }
                 Console.WriteLine();
            }
            Program obj = new Program();
            obj.Rotate(matrix);
            Console.WriteLine("Matrix after 90 degree clock wise rotation");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            // Output: [[7,4,1],[8,5,2],[9,6,3]]
      

            Console.ReadLine();

        }
    }
}
