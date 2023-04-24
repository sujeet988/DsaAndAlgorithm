using System;
using System.Collections.Generic;

namespace PrintMatrixInSnakePattern
{
    internal class Program
    {
        /*
         * https://practice.geeksforgeeks.org/problems/print-matrix-in-snake-pattern-1587115621/1
         * N = 3 
                matrix[][] = {{45, 48, 54},
                             {21, 89, 87}
                             {70, 78, 15}}
                Output: 45 48 54 87 89 21 70 78 15 
                Explanation:
                Matrix is as below:
                45 48 54
                21 89 87
                70 78 15
                Printing it in snake pattern will lead to 
                the output as 45 48 54 87 89 21 70 78 15.
         * 
         */
        public static List<int> snakePattern(List<List<int>> matrix)
        {
            int n = matrix.Count;
            List<int> result = new List<int>();
           for(int row=0; row < n; row++)
            {
                if (row == 0 || row % 2 ==0)
                {
                    for (int col = 0; col < matrix[row].Count; col++)
                    {
                        result.Add(matrix[row][col]);
                    }
                }
                else if (row % 2 == 1)
                {
                    for (int col = matrix[row].Count-1; col >=0; col--)
                    {
                        result.Add(matrix[row][col]);
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("snakePattern");

            List <List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int> { 45, 48, 54 });
            matrix.Add(new List<int> { 21, 89, 87 });
            matrix.Add(new List<int> { 70, 78, 15 });
            int n = matrix.Count;
            var output = snakePattern(matrix);
            foreach(var item in output)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
