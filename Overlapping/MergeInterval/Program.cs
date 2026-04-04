namespace MergeInterval
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/merge-intervals/description/
         * 
         */

        public static int[][] MergeIntervalWithBruteForce(int[][] intervals)
        {
          int n = intervals.Length;

            bool[] vistied = new bool[n];

            List<int[]> result = new List<int[]>();

            for(int i =0; i < n; i++)
            {
                if (vistied[i]) continue;

                int start = intervals[i][0];
                int end = intervals[i][1];

                for(int j = i+1; j < n; j++)
                {
                    if (vistied[j])
                    {
                        continue;
                    }
                    if (!(intervals[j][0] > end || intervals[j][1] < start))
                    {
                        // merge
                        start =  Math.Min(start, intervals[j][0]);
                        end = Math.Max(end, intervals[j][1]);
                        vistied[j] = true;
                    }
                }

                result.Add(new int[] { start, end });
            }

            return result
                .ToArray();

        }
        public static int[][] MergeIntervalWithBruteForce2(int[][] intervals)
        {
            int n = intervals.Length;

            bool[] vistied = new bool[n];

            List<int[]> result = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                if (vistied[i]) continue;

                int start = intervals[i][0];
                int end = intervals[i][1];

                for (int j = i + 1; j < n; j++)
                {
                    if (vistied[j])
                    {
                        continue;
                    }
                    bool isoverlap = intervals[j][0] <= end && intervals[j][1] >= start;
                    if (isoverlap)
                    {
                        start = Math.Min(start, intervals[j][0]);
                        end = Math.Max(end, intervals[j][1]);
                        vistied[j] = true;
                    }
                }

                result.Add(new int[] { start, end });
            }

            return result
                .ToArray();

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Merge Interval Demo");

            int[][] intervals = new int[4][];
            intervals[0] = new int[2] { 1,3};
            intervals[1] = new int[2]{ 2,6};
            intervals[2] = new int[2] { 8, 10 };
            intervals[3] = new int[2] { 15, 18 };

            //for (int i = 0; i < intervals.Length; i++)
            //{
            //    for(int j =0; j < intervals[i].GetLength(0); j++)
            //    {
            //        Console.Write(intervals[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            var result = MergeIntervalWithBruteForce2(intervals);

            foreach(int[] i in result)
            {

                foreach(var item in i)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

            }

            //Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
