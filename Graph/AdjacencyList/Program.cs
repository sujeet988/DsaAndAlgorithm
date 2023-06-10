using System;
using System.Collections.Generic;

namespace DsaAndAlgorithm.Graph.AdjacencyList
{
    public class Program
    {

        public class Edge
        {
            public int source;
            public int destination;
            public Edge(int s, int d)
            {
                this.source = s;
                this.destination = d;

            }
        }
        public static void CreateGraph(List<List<Edge>> graph, int vertices)
        {
            for (int i = 0; i < vertices; i++)
            {
                graph.Add(new List<Edge>());
            }

            graph[0].Add(new Edge(0, 2));

            graph[1].Add(new Edge(1, 2));
            graph[1].Add(new Edge(1, 3));

            graph[2].Add(new Edge(2, 0));
            graph[2].Add(new Edge(2, 1));
            graph[2].Add(new Edge(2, 3));

            graph[3].Add(new Edge(3, 1));
            graph[3].Add(new Edge(3, 2));
        }

        public static void PrintAdjacencyList(List<List<Edge>> graph,int numVertices)
        {

            foreach (var neighbor in graph)
            {
                foreach (var edge in neighbor)
                {
                    Console.WriteLine("Source :{0} Destinatio : {1}",edge.source,edge.destination);
                }

                Console.WriteLine();
            }

            
               
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("AdjacencyList graph example with list");
            int numofVertices = 4;
            List<List<Edge>> graph = new List<List<Edge>>();
            CreateGraph(graph, numofVertices);
            PrintAdjacencyList(graph, numofVertices);
            Console.ReadLine();

        }
    }
}
