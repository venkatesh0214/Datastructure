using System;

namespace FindNumberOfIslands
{
    class MainClass
    {

        public static bool[,] visited;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[,] graph = new int[,]
                                { { 1, 1, 0, 0, 0 },
                                  { 0, 1, 0, 0, 1 },
                                  { 1, 0, 0, 1, 1 },
                                  { 0, 0, 0, 0, 0 },
                                  { 1, 0, 1, 0, 1 } };

            countIsland(graph);

            Console.ReadLine();
        }

        public static void countIsland(int[,] graph)
        {


            int Row = graph.GetLength(0), Col = graph.GetLength(1);
            visited = new bool[Row,Col];

            int count = 0;
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    if (graph[i, j] == 1 && visited[i, j] != true)
                    {
                        Console.WriteLine(i+","+j);
                        DFS(graph, Row, Col);
                        ++count;             
                    }

        }

        public static void DFS(int[,] graph, int row, int col)
        {

            int[] RowLmit = { -1,0,1,-1,1,-1,0,-1};
            int[] ColLmit = { 1,1,1,0,0,-1,-1,-1};

            for (int i = 0; i < 8; i++)
               
                    if (graph[i, j] == 1 && visited[i, j] != true)
                    {
                        
                        
                    }

        }

    }
}
