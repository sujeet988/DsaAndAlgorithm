namespace InterchangingTheRowsofaMatrix
{
    internal class Program
    {
        /*
         * https://www.geeksforgeeks.org/java-program-to-interchange-elements-of-first-and-last-in-a-matrix-across-rows/
         */

        public static void Interhchange(int[][] matrix)
        {

          int row=matrix.Length;
          int col = matrix[0].Length;

            for(int i=0; i < row/2; i++) 
            { 
                for(int j=0; j < col; j++)
                {
                    int temp = matrix[i][j];
                    int last = matrix[row - 1 - i][j]; // last row
                    matrix[i][j] = last;
                    matrix[row - 1 - i][j] = temp;
                }
            
            
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Interchanging The Rows of a Matrix");
            // create a matrix

            int[][] arr = new int[4][];
            arr[0] = new int[4] { 1,2,3,4};
            arr[1] = new int[4] { 5,6,7,8 };
            arr[2] = new int[4] { 9,10,11,12 };
            arr[3] = new int[4] { 13,14,15,16};
            for(int i=0; i < arr.Length; i++) 
            { 
                for(int j=0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");

                }
                Console.WriteLine();    
            }
            Console.WriteLine(" After interchange");
            Interhchange(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}