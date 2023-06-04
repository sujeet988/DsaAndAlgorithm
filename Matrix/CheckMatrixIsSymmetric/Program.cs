using System;

namespace DsaAndAlgorithm.Matrix.CheckMatrixIsSymmetric
{
    /*
     * A square matrix is said to be symmetric matrix if the transpose of the matrix is same as the given matrix
     * https://www.geeksforgeeks.org/program-to-check-if-a-matrix-is-symmetric/
     * https://www.codingninjas.com/codestudio/problems/matrix-is-symmetric_799361?utm_source=youtube&utm_medium=affiliate&utm_campaign=parikh_youtube
     */
    internal class Program
    {
        public static bool isSymmetric(int[,] matrix)
        {
            // Check if the matrix is square
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows != cols)
            {
                return false;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }
            }

            return true;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Symmtrerix matrx demo");
            int[,] matrix = { { 1, 3, 5 },
                    { 3, 2, 4 },
                    { 5, 4, 1 } };
            if (isSymmetric(matrix))
                Console.WriteLine("Yes"); // yes output
            else

                Console.WriteLine("NO");

            Console.ReadLine();
        }
    }
}
