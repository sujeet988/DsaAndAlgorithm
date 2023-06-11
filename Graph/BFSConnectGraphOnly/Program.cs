using System;
using System.Collections.Generic;

namespace DsaAndAlgorithm.Graph.BFSConnectGraphOnly
{
    public class Program
    {

        public class Edge
        {
            public int Source { get; set; }
            public int Destination { get; set; }
            public Edge(int source, int destination)
            {
                this.Source = source; this.Destination = destination;
            }
        }

        public static void CreateAdjacenyList(List<List<Edge>> graphAdjacenyList, int vertices)
        {
            for (int i = 0; i < vertices; i++)
            {
                graphAdjacenyList.Add(new List<Edge>());
            }

            graphAdjacenyList[0].Add(new Edge(0, 1));
            graphAdjacenyList[0].Add(new Edge(0, 2));

            graphAdjacenyList[1].Add(new Edge(1, 0));
            graphAdjacenyList[1].Add(new Edge(1, 2));
            graphAdjacenyList[1].Add(new Edge(1, 3));

            graphAdjacenyList[2].Add(new Edge(2, 0));
            graphAdjacenyList[2].Add(new Edge(2, 1));
            graphAdjacenyList[2].Add(new Edge(2, 3));
            graphAdjacenyList[2].Add(new Edge(2, 4));

            graphAdjacenyList[3].Add(new Edge(3, 1));
            graphAdjacenyList[3].Add(new Edge(3, 2));
            graphAdjacenyList[3].Add(new Edge(3, 4));

            graphAdjacenyList[4].Add(new Edge(4, 2));
            graphAdjacenyList[4].Add(new Edge(4, 3));
        }

        public static void PrintAdjacenyList(List<List<Edge>> graphAdjacenyList, int vertices)
        {

            for (int i = 0; i < graphAdjacenyList.Count; i++)
            {

                for (int j = 0; j < graphAdjacenyList[i].Count; j++)
                {
                    Console.Write(graphAdjacenyList[i][j].Destination);

                }
                Console.WriteLine();

            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("BFS Demo");
            //First Create Input
            int numofVertices = 5;
            List<List<Edge>> graphAdjacenyList = new List<List<Edge>>();
            CreateAdjacenyList(graphAdjacenyList, numofVertices);
            //Print AdjacenyList
            PrintAdjacenyList(graphAdjacenyList, numofVertices);
            Console.ReadLine();

        }




    }
}
