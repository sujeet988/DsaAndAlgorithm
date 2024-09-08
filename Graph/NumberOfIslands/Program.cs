namespace NumberOfIslands
{
    /*
     * 200 https://leetcode.com/problems/number-of-islands/description/
     */
    internal class Program
    {
        //cheking base condtion
        public static bool Isvalid(int i, int j, int row, int col, char[][] grid)
        {
            if (i >= 0 && i < row && j >= 0 && j < col && grid[i][j] == '1')
            {
                return true;
            }
            return false;

        }
        public static void DFSRec(int i, int j, int row, int col, char[][] grid) 
        {
            grid[i][j] = '0'; // first  make zero

            //then check for adjacent
            if (Isvalid(i+1, j, row, col, grid))
            {
                DFSRec(i+1,j,row,col, grid); // right side
            }
            if (Isvalid(i - 1, j, row, col, grid))
            {
                DFSRec(i - 1, j, row, col, grid); // left side
            }
            if (Isvalid(i , j+1, row, col, grid))
            {
                DFSRec(i , j+1, row, col, grid); // up side
            }
            if (Isvalid(i , j-1, row, col, grid))
            {
                DFSRec(i, j-1, row, col, grid); // down  side
            }


        }

        public int NumIslands(char[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            int noofisland = 0;
            for(int i=0; i < row; i++)
            {
                for(int j=0; j < col; j++) 
                {
                    if (grid[i][j] == '1')
                    {
                        noofisland++;
                        DFSRec(i,j,row,col, grid);
                    }
                }
            }


            return noofisland;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of Island");

            // creat matrix for n & m
            int n = 4;
            const int m = 5;
            char[][] grid = new char[n][];
            grid[0] = new char[m] { '1', '1', '0', '0', '0' };
            grid[1] = new char[m] { '1', '1', '0', '0', '0' };
            grid[2] = new char[m] { '0', '0', '1', '0', '0' };
            grid[3] = new char[m] { '0', '0', '0', '1', '1' };

            // print matrix
           for(int i=0; i<n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    Console.Write(grid[i][j]+" ");
                }
                Console.WriteLine();
            }

            Program p = new Program();
            var noofisland = p.NumIslands(grid);
            Console.WriteLine($"number if island is {noofisland}"); //// ans is 3;

            Console.ReadLine();


        }
    }


}