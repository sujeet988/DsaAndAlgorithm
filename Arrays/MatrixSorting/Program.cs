namespace MatrixSorting
{
    internal class Program
    {
        static void Print(int[][] arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine($"[{i[0]}, {i[1]}]");
            }
        }
        static void Main(string[] args)
        {
            int[][] intervals = new int[][]
            {
                new int[] {5, 8},
            new int[] {1, 3},
            new int[] {10, 3},
            new int[] {2, 6}
            };
            Console.WriteLine("Original Data:");
            Print(intervals);

            // sort by start
            Array.Sort(intervals,(a,b) => a[0].CompareTo(b[0]));
            Console.WriteLine("\nSorted by START:");
            Print(intervals);
            // Reset data
            intervals = new int[][]
            {
            new int[] {5, 8},
            new int[] {1, 3},
            new int[] {10, 3},
            new int[] {2, 6}
            };

            // ✅ Sort by END
            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
            Console.WriteLine("\nSorted by end:");
            Print(intervals);

            Console.ReadLine();



        }
    }
}
