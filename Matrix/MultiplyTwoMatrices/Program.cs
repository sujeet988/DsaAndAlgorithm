using System;

namespace MultiplyTwoMatrices
{
    /*
     * The number of columns in Matrix-1 must be equal to the number of rows in Matrix-2.
        Output of multiplication of Matrix-1 and Matrix-2, results with equal to the number of rows of Matrix-1 and  the number of columns of Matrix-2 i.e. rslt[R1][C2]
     * https://www.geeksforgeeks.org/c-program-multiply-two-matrices/
     * https://practice.geeksforgeeks.org/problems/multiply-2-matrices4144/1
     * 
     */
    internal class Program
    {

        public  static void Mutliply(int[,] matrixA, int[,] matrixB)
        {


            // get the dimensions of the matrices
            int rows1 = matrixA.GetLength(0);
            int cols1 = matrixA.GetLength(1);
            int rows2 = matrixB.GetLength(0);
            int cols2 = matrixB.GetLength(1);

            // initialize the result matrix
            int[,] result = new int[rows1, cols2];

            if (cols1 == rows2) // if columa of matrix 1 equal to row of matrix two then only we can do mutiply matrix.
            {
                // perform matrix multiplication
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < cols1; k++)
                        {
                            sum += matrixA[i, k] * matrixB[k, j];
                        }
                        result[i, j] = sum;
                    }
                }
            }

            // display the result matrix
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

            static void Main(string[] args)
        {
            Console.WriteLine("Mutiply Two Matrix");

            // we a have to use Rectangular2DArrays
            int[,] matrixA = new int[3,2] { { 1,1 }, { 2,2 }, { 3,3} };
            int[,] matrixB = new int[2,3] {  { 1, 1,1 }, { 2, 2 ,2} };
            Mutliply(matrixA, matrixB); //result[3][3] = { {3, 3, 3}, {6, 6, 6}, {9, 9, 9} }
            Console.ReadLine();

        }
    }
}
