using System;

namespace RottenOrange
{
    /*
     * 994 https://leetcode.com/problems/rotting-oranges/description/
     */
    internal class Program
    {
        public static int OrangesRotting(int[][] grid)
        {

            // find grid sizes
            int n=grid.Length; // row
            int m = grid[0].Length; // column

            // two way to create key value pair
            Queue<KeyValuePair<int,int>> q = new Queue<KeyValuePair<int, int>>();
            //// Queue<(int, int)> q = new Queue<(int, int)>();
            int fresh = 0;
            int time = 0;
            //Put the position of all rotten oranges in queue
            //count the number of fresh oranges
            for (int i=0; i < n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        //push into queue
                        q.Enqueue(new KeyValuePair<int, int>(i, j));
                    }
                    if (grid[i][j] == 1)
                    {
                        fresh++;
                    }
                }
            }

            // handle base case
            if(fresh==0) 
            { 
              return 0; 
            }

            // all four directional mapping
            int[] deltarow = new int[] { -1, 0, 1, 0 }; // row order- >up-> right-bottom-left
            int[] deltcol = new int[] {  0, 1, 0, -1 }; // col->  up-> right-bottom-left
            //bfs starting from initially rotten oranges
            while (q.Count > 0)
            {
                int size_q = q.Count;
                int temp = 0;
                for(int i=0; i < size_q; i++)
                {
                    KeyValuePair<int,int> current =q.Peek();
                    int r=current.Key;
                    int c = current.Value;
                    q.Dequeue();
                    // exactly 4 neighbours
                    for (int j=0; j < 4; j++) 
                    {
                        int nrow = r + deltarow[j];
                        int ncol = c + deltcol[j];
                        // check for valid coordinates a

                        if (nrow >= 0 && nrow < n && ncol >= 0 && ncol<m && grid[nrow][ncol] == 1)// checking Safe position
                        {
                            grid[nrow][ncol] = 2;
                            q.Enqueue(new KeyValuePair<int, int>(nrow,ncol));
                            temp++;
                        }
                    }

                }

                if(temp != 0) // temp !=0 means  orang chaneged from fresh to rotten
                { time++; 
                }
                

            }




            // at the  end if any of the fresh orange that is not rotten

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        time = 0;
                    }
                    
                }
            }

            return time==0 ? -1: time;
           

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Rotten Orange Demo");
            int[][] grid = new int[3][];
            grid[0] = new int[3] { 2, 1, 1 };
            grid[1] = new int[3] { 1, 1, 0 };
            grid[2] = new int[3] { 0, 1, 1 };

            // print rotten orange grid before  changes
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    Console.Write(grid[i][j] + " ");
                }
                Console.WriteLine();
            }
            // start rotting
            var mintime = OrangesRotting(grid);
            Console.WriteLine(mintime); // ans is 4

            Console.ReadLine();





        }

    }
}