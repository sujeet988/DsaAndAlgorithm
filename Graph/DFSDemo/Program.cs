﻿namespace DFSDemo
{
    /*
     * https://www.geeksforgeeks.org/problems/depth-first-traversal-for-a-graph/1
Example 1:

Input: V = 5 , adj = [[2,3,1] , [0], [0,4], [0], [2]]

Output: 0 2 4 3 1

 Time complexity: O(N+E), Where N is the time taken for visiting N nodes and E is for travelling 
 through adjacent nodes.

Space Complexity:O(N+E)+O(N)+O(N) , Space for adjacency list, Array,Auxiliary space.


     */
    internal class Program
    {
        public static int[] dfsOfGraph(int V, List<int>[] adj)
        {
            List<int> storeDfs = new List<int>();

            // approach 1

            /*
            bool[] visited = new bool[V];
            Array.Fill(visited, false);

            dfsRecursive(0, visited, adj, storeDfs);
            return storeDfs.ToArray();
            */

            //or approach 2 
            bool[] visited = new bool[V + 1]; //  we can use v or v+1

            // Perform DFS starting from each unvisited node to cover disconnected graphs
            for (int i = 0; i < V; i++)
            {
                if (!visited[i])
                {
                    dfsRecursive(i, visited, adj, storeDfs);
                }
            }
            return storeDfs.ToArray();
            

        }

        public static void dfsRecursive(int node, bool[] visited, List<int>[] adj, List<int> storeDfs)
        {
            // Storing answer
            storeDfs.Add(node);
            //marking current node as visited
            visited[node] = true;
            //getting neighbour nodes
            foreach (int it in adj[node])
            {
                if (!visited[it])
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
        /*
         * Graph Representation:

The graph is represented as an adjacency list using an array of lists. Each index in the array represents a node, and the list at each index contains the nodes that are adjacent (connected) to that node.
DFS Traversal:

The DfsOfGraph method initializes the traversal by creating a list to store the DFS result and an array to keep track of visited nodes.
It iterates over all nodes, starting the DFS from each unvisited node to ensure that even disconnected parts of the graph are covered.
The DfsRecursive method performs the actual DFS, adding the current node to the result list and marking it as visited, then recursively visiting all unvisited neighbors.
Example Usage:

In the Main method, an example graph is defined using an adjacency list.
The DfsOfGraph method is called to perform the DFS traversal.
The result is printed to the console.
         */
    }
}

