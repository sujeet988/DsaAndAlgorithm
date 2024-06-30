namespace DFSDemo
{
    /*
     * 
Example 1:

Input: V = 5 , adj = [[2,3,1] , [0], [0,4], [0], [2]]

Output: 0 2 4 3 1


     */
    internal class Program
    {
        public static int[] dfsOfGraph(int V, List<int>[] adj)
        {
            List<int> storeDfs = new List<int>();

            bool[] visited = new bool[V];
            Array.Fill(visited, false);
            dfsRecursive(0, visited, adj, storeDfs);
            return storeDfs.ToArray();
        }

        public static void dfsRecursive(int node, bool[] visited, List<int>[] adj, List<int> storeDfs)
        {
            storeDfs.Add(node);
            //marking current node as visited
            visited[node] = true;
            //getting neighbour nodes

            foreach (int it in adj[node])
            {
                if (visited[it] == false)
                {
                    dfsRecursive(it, visited, adj, storeDfs);
                }
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Create the adjacency list using List<List<int>>s
            List<List<int>> adjacencyList = new List<List<int>>();

            // Initialize the adjacency list
            adjacencyList.Add(new List<int> { 2, 3, 1 }); // Node 0
            adjacencyList.Add(new List<int> { 0 });       // Node 1
            adjacencyList.Add(new List<int> { 0, 4 });    // Node 2
            adjacencyList.Add(new List<int> { 0 });       // Node 3
            adjacencyList.Add(new List<int> { 2 });       // Node 4

            // Display adjacency list
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                Console.Write("Node " + i + ": ");
                foreach (var neighbor in adjacencyList[i])
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("DFS output");
           var output=  dfsOfGraph(adjacencyList.Count, adjacencyList.ToArray());
            foreach(var neighbor in output)
            {
             Console.WriteLine(neighbor + " ");
            }

            Console.ReadLine();
        }
    }
}

