namespace DsaAndAlgorithm.Recursion.Subset
{
    internal class Program
    {

        public static List<List<int>> SubsetUsingLoop(int[] arr)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>()); //Add an empty list as the initial subsequence
            foreach (var item in arr)
            {
                int n = subsets.Count;

                for (int i = 0; i < n; i++)
                {
                    List<int> internalsubset = new List<int>(subsets[i]);
                    internalsubset.Add(item); //// Include the current array elements

                    subsets.Add(internalsubset);
                }
            }
            return subsets;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Subset Demo using loop/Iteration");
            int[] arr = new int[] { 1, 2, 3 };
            var output = SubsetUsingLoop(arr);
            foreach (List<int> list in output)
            {
                foreach (var data in list)
                {
                    Console.Write(data);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}