namespace DsaAndAlgorithm.BackTracking.RatInMazeProblem
{
    public class Program
    {

        /*
         * https://www.codingninjas.com/studio/problems/rat-in-a-maze-_8842357?utm_source=striver&utm_medium=website&utm_campaign=a_zcoursetuf
         * https://practice.geeksforgeeks.org/problems/rat-in-a-maze-problem/1
         * Consider a rat placed at (0, 0) in a square matrix of order N * N. It has to reach the destination at (N - 1, N - 1). Find all possible paths that the rat can take to reach from source to destination. 
         * The directions in which the rat can move are 'U'(up), 'D'(down), 'L' (left), 'R' (right). Value 0 at a cell in the matrix represents that it is blocked and rat cannot move to it while value 1 at a cell in the matrix represents that rat can be travel through it.
           Note: In a path, no cell can be visited more than one time. If the source cell is 0, the rat cannot move to any other cell.
          
         Input:
            N = 4
            m[][] = {{1, 0, 0, 0},
                     {1, 1, 0, 1}, 
                     {1, 1, 0, 0},
                     {0, 1, 1, 1}}
            Output:
            DDRDRR DRDDRR
            Explanation:
            The rat can reach the destination at 
            (3, 3) from (0, 0) by two paths - DRDDRR 
            and DDRDRR, when printed in sorted order 
            we get DDRDRR DRDDRR.

            Input:
            N = 2
            m[][] = {{1, 0},
                     {1, 0}}
            Output:
            -1
            Explanation:
            No path exists and destination cell is 
            blocked.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Rat in a Maze Problem using BackTrack");
            int[][] maze = new int[4][] { new int[] { 1,0,0,0}, new int[] { 1, 1, 0, 1 } ,
            new int[] { 1, 1, 0, 0 },new int[] { 0,1,1,1}  };
            /*
             * {1, 0, 0, 0},
               {1, 1, 0, 1}, 
               {1, 1, 0, 0},
               {0, 1, 1, 1}
             */

            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze[i].Length; j++)
                {
                    Console.Write(maze[i][j] + " ");
                }
                Console.WriteLine();
            }

            int n = 4;
           var result= findPath(maze, 4);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

        public static List<String> findPath(int[][] m, int n)
        {
            List<String> ans = new List<String>();
            //create visited array with default value zero
            int[,] visited = new int[n, n];
            string path = "";

            Solve(0, 0, m, n, ans, visited, path);
            return ans;
        }
        public static void Solve(int x, int y, int[][] arr, int n, List<string> ans, int[,] visited, string path)
        {
            //Base case
            if (x == n - 1 && y == n - 1)
            {
                ans.Add(path);
                return;
            }

            // 4 movement
            // D=>Down
            // L=> Left
            // R=>Right
            // U=> Upward
            // X=> stand for row
            // Y=> stand for column

            //Down
            if(IsSafe(x+1, y, visited, arr, n))
            {
                visited[x, y] = 1;
                Solve(x+1,y,arr, n, ans, visited, path+'D');
                visited[x, y] = 0;
            }

            //Left
            if (IsSafe(x, y-1, visited, arr, n))
            {
                visited[x, y] = 1;
                Solve(x, y-1, arr, n, ans, visited, path + 'L');
                visited[x, y] = 0;
            }

            //Right
            if (IsSafe(x, y+1, visited, arr, n))
            {
                visited[x, y] = 1;
                Solve(x, y+1, arr, n, ans, visited, path + 'R');
                visited[x, y] = 0;
            }

            //Upward
            if (IsSafe(x -1, y, visited, arr, n))
            {
                visited[x, y] = 1;
                Solve(x - 1, y, arr, n, ans, visited, path + 'U');
                visited[x, y] = 0;
            }
        }

        public static bool IsSafe(int newX, int newY,int[,] visited, int[][] arr, int n)
        {
            // Check if newX, newY is within the maze bounds and the cell is not blocked
            if ((newX >= 0 && newX < n) && (newY>=0 && newY<n) 
                && visited[newX,newY] !=1 && arr[newX][newY]==1
                )
            {
                return true; 
            }
            else
            {
                return false;
            }
            
        }
    }
}