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
                Console.Write(i + " -> ");
                for (int j = 0; j < graphAdjacenyList[i].Count; j++)
                {
                    Console.Write(graphAdjacenyList[i][j].Destination + " ");

                }
                Console.WriteLine();

            }
        }

        public static void BFS(List<List<Edge>> graphAdjacenyList, int numofVertices)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[numofVertices];

            //Set starting point  of queue. as i taken 0  we can take any value like 0 or 1 or 2 etc.
            queue.Enqueue(0);
            while (queue.Count > 0) //check queue is empty or not
            {
                int currentVertex = queue.Dequeue(); //get current vertex

                if (visited[currentVertex] == false) // check current vetex is visited or not
                {
                    Console.Write(currentVertex + " "); // print current vertex
                    visited[currentVertex] = true; // mark visited as  true

                    for (int i = 0; i < graphAdjacenyList[currentVertex].Count; i++) //get all Neighbours of current vetex and add in queue
                    {
                        Edge e = graphAdjacenyList[currentVertex][i];
                        queue.Enqueue(e.Destination);

                    }
                }

            }

        }

        public static void BFSSecondWay(List<List<Edge>> graphAdjacenyList, int numofVertices)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[numofVertices];

            //Set starting point  of queue. as i taken 0  we can take any value like 0 or 1 or 2 etc.
            visited[0]=true; // in this make visted first
            queue.Enqueue(0);

            while (queue.Count > 0) //check queue is empty or not
            {
                int currentVertex = queue.Dequeue(); //Delete and get  current vertex
                Console.Write(currentVertex + " ");
                foreach (var neighbor in graphAdjacenyList[currentVertex])
                {
                    if (visited[neighbor.Destination] == false)
                    {
                        visited[neighbor.Destination] = true;
                        queue.Enqueue(neighbor.Destination);
                    }
                }
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
            Console.WriteLine();

            //BFS Traversal Way 1 
            BFS(graphAdjacenyList, numofVertices);// ouput 0 1 2 3 4
            Console.WriteLine();
            //BFS Traversal Way 2 
            BFSSecondWay(graphAdjacenyList, numofVertices);// ouput 0 1 2 3 4

            Console.ReadLine();

        }




    }
}
