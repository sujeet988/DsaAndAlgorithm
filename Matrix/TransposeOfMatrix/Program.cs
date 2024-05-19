using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TransposeOfMatrix
{

    /*Transpose of a matrix is obtained by changing rows to columns and columns to rows
     * https://www.youtube.com/watch?v=wtYv5vg6iD8&t=217s
     * https://www.youtube.com/watch?v=EmqelMa54Y4&t=15s
     * https://leetcode.com/problems/transpose-matrix/?envType=problem-list-v2&envId=mrbojnx1
     */
    internal class Program
    {

        //Function to display transpose of a matrix.
        public static void transposeDisplay(List<List<int>> matrix)
        {
            for(int i=0; i < matrix.Count; i++)
            {
                for(int j=0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[j][i]+" ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] Transpose(int[][] matrix)
        {
            int n = matrix.Length; //rows
            int m = matrix[0].Length; //col
            // now make col* rows
            int[][] result = new int[m][];
            // now initlize colums
            for(int i=0; i < m; i++)
            {
                result[i]=new int[n];
            }
            
            // now fill
            for(int i=0; i <  m; i++)
            {

                for(int j=0;  j < n; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;

        }
    



    static void Main(string[] args)
        {
            Console.WriteLine("Transpose Of Matrix With Dimension M x N ");

            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int> { 45, 48, 54 });
            matrix.Add(new List<int> { 21, 89, 87 });
            matrix.Add(new List<int> { 70, 78, 15 });

            Console.WriteLine("before transpose") ;
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("After transpose");
            transposeDisplay(matrix);

            Console.WriteLine("----------------------") ;
            ///  Jagged Array
            int[][] arr = new int[2][];
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[3] { 4, 5, 6 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("After Transpose");
            var arr1 = Transpose(arr);

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
