namespace MergeInterval
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/merge-intervals/description/
         * 
         */

        public static int[][] Merge(int[][] intervals)
        {
            int[][] arr = new int[2][];

            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Merge Interval Demo");

            int[][] intervals = new int[4][];
            intervals[0] = new int[2] { 1,3};
            intervals[1] = new int[2]{ 2,6};
            intervals[2] = new int[2] { 8, 10 };
            intervals[3] = new int[2] { 15, 18 };

            for (int i = 0; i < intervals.Length; i++)
            {
                for(int j =0; j < intervals[i].GetLength(0); j++)
                {
                    Console.Write(intervals[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
