namespace MergeInterval
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/merge-intervals/description/
         * https://www.youtube.com/watch?v=rpzaI1EPYSI&list=PLVItHqpXY_DDIcGOOm0QvpWCUvlDfvlTc
         * help by cto bhaiya 
         * When two Interval overlap : 
           i1 = [s1,e1]
           i2  = [s2,e2]
         * When twp interval not overlap : when second event  start after the first fist even is completed
           example :  s2 > e1 
         * when first event starts after the second  event is completed -
            s1 > e2

          so final format wehn s2 > e1 || s1 > e2 so they do not overlap each other 
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
                    if (!(intervals[j][0] > end || start >intervals[j][1]  ))
                    {
                        // NOT (no overlap)

                        // intervals[j][0] > end   → current interval is completely after
                        // intervals[j][1] < start → current interval is completely before

                        // If neither of the above is true → intervals overlap

                        // Merge intervals
                        start = Math.Min(start, intervals[j][0]); // take smallest start
                        end = Math.Max(end, intervals[j][1]);     // take largest end
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


        public static int[][] MergeIntervalOptimized(int[][] intervals)
        {
            if (intervals.Length == 0)
            {

                return intervals;
            }

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            List<int[]> result = new List<int[]>();
            int[] newinterval = intervals[0];

            result.Add(newinterval);

            foreach (int[] interval in intervals)
            {
                if (interval[0] <= newinterval[1])
                {
                    // overlapping interval
                    // update end if needed
                    newinterval[1] = Math.Max(newinterval[1], interval[1]);

                }
                else
                {
                    // disjoint intervals
                    // add the new interval to the list 
                    newinterval = interval;
                    result.Add(newinterval);
                }
            }



            return result.ToArray();

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

            var result = MergeIntervalOptimized(intervals);

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
