namespace MinmValuePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 4, 2, 1, 3 };
            var  result = Program.minimumeifferecen(arr);
            foreach(var list in result)
            {
                Console.WriteLine();

                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            int[] arr1 = { 5, 2, 9, 1, 11, 6 };
            var result1 = Program.way2(arr1);
            Console.WriteLine(result1[0]);
            Console.WriteLine(result1[1]);

            Console.ReadLine();
        }

        public static IList<IList<int>> minimumeifferecen(int[] arr)
        {
            Array.Sort(arr);
            IList<IList<int>> result = new List<IList<int>>();
            int mindiff = Int32.MaxValue;
            int len = arr.Length;


            for (int i = 0; i < len-1; i++)
            {
                int diff= arr[i+1]-arr[i];
                if (diff < mindiff)
                {
                    mindiff = diff;
                    result.Clear(); // // reset result for new min diff
                    result.Add(new List<int> { arr[i], arr[i + 1] });


                }
                else if (diff == mindiff)
                {
                    result.Add(new List<int> { arr[i], arr[i + 1] });
                }
            }
            return result;

        }

        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> li = new List<IList<int>>();
            int mindiff = Int32.MaxValue;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    int diff = Math.Abs(arr[i] - arr[j]);
                    if (diff < mindiff)
                    {
                        mindiff = diff;
                        li.Clear();
                        li.Add(new List<int> { arr[i], arr[j] });
                    }
                    else if (diff == mindiff)
                    {
                        li.Add(new List<int> { arr[i], arr[j] });
                    }
                }
            }
            return li;
        }

        public static int[] way2(int[] arr1)
        {
              int[] result = new int[2];
              Array.Sort(arr1);
              int mindffo = Int32.MaxValue;
              int len = arr1.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int diff = arr1[i + 1] - arr1[i];
                if (diff < mindffo)
                {
                    mindffo = diff;
                    result[0] = arr1[i];
                    result[1] = arr1[i + 1];
                }
            }
            return result;

        }
    }
}
