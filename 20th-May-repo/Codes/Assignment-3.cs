using System;

class Programming
{
    // Function to find the vertex with the minimum distance value, from
    // the set of vertices not yet included in shortest path tree
    static int MinDistance(int[] dist, bool[] visited, int V)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    public static void Main()
    {
        int[,] graph = new int[5, 5]
        {
            {0,10,0,30,100},
            {0,0,50,0,0},
            {0,0,0,0,10},
            {0,0,20,0,60},
            {0,0,0,0,0}
        };

        int Vertices = 5;
        int[] dist = new int[Vertices];
        bool[] visited = new bool[Vertices];
        int[] prev = new int[Vertices];

        // Initialize arrays
        for (int i = 0; i < Vertices; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            prev[i] = -1; // no predecessor
        }

        int source = 0;
        dist[source] = 0;

        for (int count = 0; count < Vertices - 1; count++)
        {
            int u = MinDistance(dist, visited, Vertices);
            visited[u] = true;

            for (int v = 0; v < Vertices; v++)
            {
                // Check if v is not visited, there is an edge from u to v,
                // and total weight of path from source to v through u is smaller
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    prev[v] = u;
                }
            }
        }

        // Output the shortest distances
        Console.WriteLine("Vertex\tDistance from Source");
        for (int i = 0; i < Vertices; i++)
        {
            Console.WriteLine($"{i}\t{dist[i]}");
        }

        // Optional: Print shortest path from source to each vertex
        for (int i = 0; i < Vertices; i++)
        {
            Console.Write($"Path to vertex {i}: ");
            PrintPath(prev, i);
            Console.WriteLine();
        }
    }

    static void PrintPath(int[] prev, int v)
    {
        if (v == -1)
            return;
        PrintPath(prev, prev[v]);
        Console.Write($"{v} ");
    }
}