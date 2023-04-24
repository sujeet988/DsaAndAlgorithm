using System;

namespace MatrixMultiDimensionArray
{
    /*
     * What is a Two-Dimensional Array in C#?
    The arrays which store the elements in the form of rows and columns are called Two-Dimensional Array in C#. The two-dimensional array which is also called a multidimensional array is of two types in C#. They are as follows

      Rectangular Array: The array whose rows and columns are equal is called a rectangular array
      Jagged Array: The array whose rows and columns are not equal is called a jagged array
     * */

    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangular 2D Arrays
            // this is not similar to java
            // little tough to under stand
            TwoDimensionArrayDemo.Rectangular2DArrays();

            //jagged array
            //jagged array is similar to java array
            TwoDimensionArrayDemo.Jagged2DArrays();
            Console.ReadLine();

           
        }
    }
}
