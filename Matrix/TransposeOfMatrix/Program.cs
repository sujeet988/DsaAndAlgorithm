using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TransposeOfMatrix
{

    /*Transpose of a matrix is obtained by changing rows to columns and columns to rows
     * https://www.youtube.com/watch?v=wtYv5vg6iD8&t=217s
     * https://www.youtube.com/watch?v=EmqelMa54Y4&t=15s
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

            Console.ReadLine();
        }
    }
}
