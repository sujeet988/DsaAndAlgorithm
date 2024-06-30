namespace NumberOfIslands
{
    /*
     * 200 https://leetcode.com/problems/number-of-islands/description/
     */
    internal class Program
    {
        public int NumIslands(char[][] grid)
        {

            return 0;
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
            Console.WriteLine($"number if island is {0}", noofisland);

            Console.ReadLine();


        }
    }


}