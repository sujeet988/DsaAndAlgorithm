using System.Net.Http.Headers;

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

        ////public static void SubsetUsingListofList(List<int> processed,int[] unprocessed, int index, List<List<int>> ans)
        ////{
        ////    if (index >=unprocessed.Length)
        ////    {
        ////        ans.Add(processed);
        ////        return;
        ////    }
        ////    // Exclude the current element
        ////    SubsetUsingListofList(processed, unprocessed, index + 1, ans);
        ////    // Include the current element
        ////    int item = unprocessed[index];
        ////    processed.Add(item);
        ////    SubsetUsingListofList(processed, unprocessed,index+1, ans); ///// Include the current item
        ////}

        public static void SubsetUsingListofList(List<int> processed, int[] unprocessed, int index, IList<IList<int>> ans)
        {
            if (index >= unprocessed.Length)
            {
                ans.Add(processed);
                return;
            }
            // Exclude the current element
            SubsetUsingListofList(processed, unprocessed, index + 1, ans);
            // Include the current element
            int item = unprocessed[index];
            processed.Add(item);
            SubsetUsingListofList(processed, unprocessed, index + 1, ans); ///// Include the current item
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

            Console.WriteLine("Subset Demo using Recursion");
            IList<IList<int>> ans=new List<IList<int>>();
            List<int> processed=new List<int>();
            int index = 0;
            SubsetUsingListofList(processed,arr, index, ans);
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