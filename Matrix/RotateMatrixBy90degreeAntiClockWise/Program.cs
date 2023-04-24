using System;
using System.Collections;
using System.Collections.Generic;

namespace RotateMatrixBy90degreeAntiClockWise
{
    /*
     * https://practice.geeksforgeeks.org/problems/rotate-by-90-degree-1587115621/1
     * https://www.youtube.com/watch?v=yIUryrv2I7I&list=PLzjZaW71kMwRff0CCcrB93srEiQhJoOzg&index=4
     * Given a square matrix of size N x N. The task is to rotate it by 90 degrees in anti-clockwise direction without using any extra space. 
      */
    internal class Program
    {
        //Function to rotate matrix anticlockwise by 90 degrees.
        public static void rotateby90AntclockWise(List<List<int>> matrix, int n)
        {
            //Transpose and Reverse the array
            TransposeMatrix(matrix, n);
            ReverseColumns(matrix, n);

        }

        private static void TransposeMatrix(List<List<int>> matrix, int n)
        { 
            for(int row=0; row < n; row++)
            {
                for(int col=0; col <= row; col++)
                {
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[col][row];
                    matrix[col][row]= temp;
                }
            }
        
        }

        private static void ReverseColumns(List<List<int>> matrix, int n)
        {
            //reverse colum data using two loop
            //for (int i = 0; i < n / 2; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        int x = matrix[i][j];
            //        matrix[i][j] = matrix[n - 1 - i][j];
            //        matrix[n - 1 - i][j] = x;
            //    }
            //}

            //reverse colum data using two pointer
            for (int row = 0; row < n; row++)
            {
                int start = 0;
                int end = n - 1;
                while (start < end)
                {
                    int temp = matrix[start] [row];
                    matrix[start][row] = matrix[end][row];
                    matrix[end][row] = temp;
                    start++;
                    end--;
                   
                }
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Rotate by 90 degree With Dimension N x N ");

            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int> { 1,2,3 });
            matrix.Add(new List<int> { 4,5,6 });
            matrix.Add(new List<int> {7,8,9});

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
            rotateby90AntclockWise(matrix, matrix.Count);

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
