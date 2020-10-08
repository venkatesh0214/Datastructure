using System;
using System.Collections.Generic;

namespace GraphImplementation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Graph World!");

            classGraph graph = new classGraph(5);

            graph.addEdges(0,1);
            graph.addEdges(0, 4);

            graph.addEdges(1, 0);
            graph.addEdges(1, 4);
            graph.addEdges(1, 2);
            graph.addEdges(1, 3);

            graph.addEdges(2, 1);
            graph.addEdges(2, 3);

            graph.addEdges(3, 1);
            graph.addEdges(3, 2);
            graph.addEdges(3, 4);

            graph.addEdges(4, 0);
            graph.addEdges(4, 1);
            graph.addEdges(4, 3);


            graph.printAdjList();
        }

       
        
    }

        public class classGraph
        {

            int Vertices;
            List<Int32>[] adjList;

            public classGraph(int v)
            {
                this.Vertices = v;
                this.adjList = new List<Int32>[v];

                for (int i = 0; i < v; i++)
                {
                     adjList[i] = new List<Int32>();
                }
            }

            public void addEdges(int v, int adjV)
            { 
                this.adjList[v].Add(adjV);
            }

            public void printAdjList()
            {
                for (int i = 0; i < Vertices; i++)
                {
                    string s = "V[" + i + "] => { ";
                    foreach (int a in this.adjList[i])
                    {
                        s = s + (a + ",");
                    }
                    s = s.Substring(0, s.Length - 1);
                    s = s + "}";
                    Console.WriteLine(s);
                }

            }

        }
}
