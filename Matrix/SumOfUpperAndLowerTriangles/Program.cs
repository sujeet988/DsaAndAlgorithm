using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfUpperAndLowerTriangles
{

    /*
     * Sum of upper and lower triangles
     * https://practice.geeksforgeeks.org/problems/sum-of-upper-and-lower-triangles-1587115621/1
             * Output: 29 32
        Explanation:
        The given matrix is
        6 5 4
        1 2 5
        7 9 7
        The elements of upper triangle are
        6 5 4
          2 5
            7
        Sum of these elements is 6+5+4+2+5+7=29
        The elements of lower triangle are
        6
        1 2
        7 9 7
        Sum of these elements is 6+1+2+7+9+7= 32.
     */
    internal class Program
    {
        public static List<int> sumTriangles(List<List<int>> matrix, int n)
        {
            //code here
            int sum_lower_triangle = 0;
            int sum_upper_triangle = 0;
            List<int> sumofall = new List<int>();
            //upper traingle sum
            for (int row = 0; row < n; row++)
            {

                for (int col = n - 1; col >= row; col--)
                {
                    sum_upper_triangle += matrix[row][col];
                }

            }
            sumofall.Add(sum_upper_triangle);
            //lower traingle sum
            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col <= row; col++)
                {
                    sum_lower_triangle += matrix[row][col];
                }

            }
            sumofall.Add(sum_lower_triangle);
            return sumofall;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of upper and lower triangles");
          
            List<List<int>> matrix= new List<List<int>>();
            matrix.Add(new List<int> { 6,5,4 });
            matrix.Add(new List<int> { 1,2,5 });
            matrix.Add(new List<int> { 7,9,7 });
            int n = matrix.Count;
            var output = sumTriangles(matrix, n);
            Console.WriteLine(output); //29, 32
            Console.ReadLine();
        }

    }
}
