using System;
using System.Collections.Generic;

namespace DsaAndAlgorithm.Matrix.SumOfZero
{
    internal class Program
    {
        /*
         * https://www.codingninjas.com/codestudio/problems/array-sum_893287?utm_source=youtube&utm_medium=affiliate&utm_campaign=parikh_youtube&leftPanelTab=0
        
         you are given a binary matrix (it contains only 0s and 1s) with dimension N*M. You need
         to find  and return sum of coverages of all zeroes of the given matrix.
        coverage for a particular 0 is defined as  the total number of 1s'arround it(i.e immediate left
        , immediate right,immediate up  and immediate bottom positions)

        1 0
        0 1
        In the given matrix, there are 2 zeros. 
        For the 0 at the 1st row, 2nd column position, coverage is 2(there is 1 adjacent top one and 1 
        adjacent right one).
        For the 0 at the 2nd row, 2nd column the coverage is 2(there is 1 adjacent top one and
        1 adjacent right one).

        Hence the net coverage is 2 + 2 = 4.
         */

        public static int coverageOfMatrix(List<List<int>> mat)
        {
            int sum = 0;
            int n = mat.Count;
            int m = mat[0].Count;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        //checking the top
                        if (i > 0 && mat[i - 1][j] == 1)
                        {
                            sum++;
                        }
                        //Checking the left
                        if (j > 0 && mat[i][j - 1] == 1) sum++;

                        //Checking the bottom
                        if (i < n - 1 && mat[i + 1][j] == 1) sum++;
                        //Checking the right
                        if (j < m - 1 && mat[i][j + 1] == 1) sum++;
                    }
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix Zero sum");
            //Creating input
            List<List<int>> list = new List<List<int>>();
            List<int> temp = null;
            temp = new List<int>();
            temp.Add(1);
            temp.Add(0);
            list.Add(temp);
            temp = new List<int>();
            temp.Add(0);
            temp.Add(1);
            list.Add(temp);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(list[i][j]);
                }
                Console.WriteLine();
            }

            //output
            int ouput = coverageOfMatrix(list);
            Console.WriteLine(ouput); //ans 4

            /*
            In the given matrix, there are 2 zeros.
            For the 0 at the 1st row, 2nd column position, coverage is 2(there is 1 adjacent top one and 
            1 adjacent right one).
            For the 0 at the 2nd row, 2nd column the coverage is 2(there is 1 adjacent top one and 1 
            adjacent right one).
            Hence the net coverage is 2 + 2 = 4.
            */
            Console.ReadLine();

        }
    }
}
