namespace MergeIntervals
{
    internal class Program
    {

        /*
         * https://leetcode.com/problems/merge-intervals/
         * Example 1:

            Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
            Output: [[1,6],[8,10],[15,18]]
            Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
            Example 2:

            Input: intervals = [[1,4],[4,5]]
            Output: [[1,5]]
            Explanation: Intervals [1,4] and [4,5] are considered overlapping.
         */

        public int[][] Merge(int[][] intervals)
        {
            int[][] result  = new int[intervals.Length][];
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Interval Demo");


            int[][] overlaps = new int[][] {
            
                new int[]{1,3 },
                new int[]{2,6 },
                new int[]{ 8,10 },
                new int[]{15,18 }

            };

            Program p = new Program();
            var respomnse =p.Merge(overlaps);



            Console.ReadLine();
        }
    }
}
