using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiDimensionArray
{
    internal class TwoDimensionArrayDemo
    {

        public static void Rectangular2DArrays()
        {
            ////2d Array with 2 rows and 3 columns;
            int[,] RectangleArray = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };

            //Printing the values of array by using nested for loop
            //arr.GetLength(0): Returns the size of the Row
            //arr.GetLength(1): Returns the size of the Column

            for(int row=0; row< RectangleArray.GetLength(0); row++) 
            {

                for(int col=0; col< RectangleArray.GetLength(1); col++)
                {
                    Console.Write(RectangleArray[row, col] +" ");
                }
                Console.WriteLine();
            }
        }

        public static void Jagged2DArrays()
        {
            int[][] jaggedArray1 = new int[2][] {  new int[]{1,2},new int[] { 3,4} };

            // another way to create

            int[][] arr4 = new int[4][];
            //Initializing each row with different column size
            //Uisng one dimensional array
            arr4[0] = new int[5];
            arr4[1] = new int[6];
            arr4[2] = new int[4];
            arr4[3] = new int[5];

            /// third way 

            ////2d Array with 2 rows and 4 and 3 columns columns;
            int[][] jaggedArray = new int[2][] { new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 } };
            Console.WriteLine("Arrays Length"+jaggedArray.Length);
            //Printing the values of array by using nested for loop
            for (int row = 0; row < jaggedArray.Length; row++)
            {

                Console.Write("rows {0} : ",row);

                for (int col = 0; col < jaggedArray[row].Length ; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
       
    }
}
