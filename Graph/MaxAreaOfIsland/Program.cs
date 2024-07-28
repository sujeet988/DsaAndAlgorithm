
namespace MaxAreaOfIsland
{
    /*
     * https://leetcode.com/problems/max-area-of-island/description/
     */
    internal class Program
    {
        public static int MaxAreaOfIsland(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            int ans = 0;
            for (int i=0; i < row; i++) 
            {
                for(int j =0; j < col; j++) 
                { 
                    if(grid[i][j] == 1) 
                    {
                        int[] area = new int[1]; // taken array as call by rference not supported for int
                        dfsrecusrive(i, j, row, col, grid, area);
                        ans = Math.Max(area[0], ans);

                    }
                }
            }
            return ans;

        }

        public static void dfsrecusrive(int i, int j, int row, int col, int[][] grid, int[] area)
        {
            area[0]++;
            grid[i][j] = 0;
            if (IsSafe(i + 1, j, row, col, grid))
            {
                dfsrecusrive(i+1,j,row,col, grid, area);
            }
            if (IsSafe(i -1, j, row, col, grid))
            {
                dfsrecusrive(i -1, j, row, col, grid, area);
            }
            if (IsSafe(i, j+1, row, col, grid))
            {
                dfsrecusrive(i, j+1, row, col, grid, area);
            }
            if (IsSafe(i, j - 1, row, col, grid))
            {
                dfsrecusrive(i, j - 1, row, col, grid, area);
            }

        }

        // issafe
        public static bool IsSafe(int x, int y, int row, int col, int[][] grid)
        {
            if(x>=0 && x < row && y>=0 && y < col && grid[x][y] == 1) 
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Max area of island");
            // CREATE a grid
            int row = 4;
            int[][] grid = new int[row][];

            grid[0] = new int[5] { 0, 1, 1, 0, 1 };
            grid[1] = new int[5] { 1, 0, 1, 0, 1 };
            grid[2] = new int[5] { 0, 1, 1, 0, 1 };
            grid[3] = new int[5] { 0, 1, 0, 0, 1 };
            // print grid

            for (int i = 0; i < grid.Length; i++)
            {
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        Console.Write(grid[i][j] + " ");
                    }
                    Console.WriteLine();

                }

            }
            var outputmaxareaofisland = MaxAreaOfIsland(grid);
            Console.WriteLine("max areaa of island is " + outputmaxareaofisland); // 6
            Console.ReadLine();
        }
    }
}