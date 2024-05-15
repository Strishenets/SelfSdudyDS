using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Graph g1 = new Graph(6);
        g1.AddEdge(1, 2, 1);
        g1.AddEdge(2, 3, 1);
        g1.AddEdge(2, 4, 1);
        g1.AddEdge(2, 5, 2);
        g1.AddEdge(3, 6, 1);
        g1.AddEdge(4, 5, 1);
        g1.AddEdge(5, 6, 1);

        Console.WriteLine("Лабораторна робота №3:");
        Console.WriteLine("Граф g1:");
        g1.PrintGraph();
        Console.WriteLine();

        Console.WriteLine("Матриця сумiжностi графа g1:");
        int[,] adjacencyMatrixG1 = g1.AdjacencyMatrix();
        for (int i = 0; i < g1.V; i++)
        {
            for (int j = 0; j < g1.V; j++)
            {
                Console.Write(adjacencyMatrixG1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Матриця iнцидентностi графа g1:");
        int[,] incidenceMatrixG1 = g1.IncidenceMatrix();
        for (int i = 0; i < g1.V; i++)
        {
            for (int j = 0; j < incidenceMatrixG1.GetLength(1); j++)
            {
                Console.Write(incidenceMatrixG1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Хроматичне число графа g1: " + g1.ChromaticNumber());
        Console.WriteLine();
        Console.WriteLine("Реберне хроматичне число графа g1: " + g1.EdgeChromaticNumber());
        Console.WriteLine();

        Console.WriteLine("Пошук усiх ейлерових циклiв та ланцюгiв для графа g1:");
        List<List<int>> eulerianCircuitsAndPathsG1 = g1.FindEulerianCircuitsAndPaths();
        foreach (var circuitOrPath in eulerianCircuitsAndPathsG1)
        {
            Console.WriteLine(string.Join(" -> ", circuitOrPath.Select(v => v + 1)));
        }
        Console.WriteLine();

        Console.WriteLine("Виконання DFS для графа g1:");
        bool[] visitedG1 = new bool[g1.V];
        g1.DepthFirstSearch(0, visitedG1);
        Console.WriteLine("\n");

        Console.WriteLine("Алгоритм Дейкстри для графа g1:");
        g1.Dijkstra(0);
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань мiж будь-якою парою вершин для графа g1:");
        (int source, int destination) = g1.ShortestDistanceBetweenAnyTwoVerticesWithShortestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source + 1) + " та вершиною " + (destination + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("--------------------------------------------------------------------------------------");

        Graph g2 = new Graph(6);
        g2.AddEdge(1, 2, 9);
        g2.AddEdge(1, 3, 3);
        g2.AddEdge(1, 4, 4);
        g2.AddEdge(1, 5, 9);
        g2.AddEdge(1, 6, 3);
        g2.AddEdge(3, 4, 7);
        g2.AddEdge(3, 5, 5);
        g2.AddEdge(4, 5, 9);
        g2.AddEdge(4, 6, 5);
        g2.AddEdge(5, 6, 3);

        Console.WriteLine("Лабораторна робота №4:");
        Console.WriteLine("Граф g2:");
        g2.PrintGraph();
        Console.WriteLine();

        Console.WriteLine("Матриця сумiжностi графа g2:");
        int[,] adjacencyMatrixG2 = g2.AdjacencyMatrix();
        for (int i = 0; i < g2.V; i++)
        {
            for (int j = 0; j < g2.V; j++)
            {
                Console.Write(adjacencyMatrixG2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Матриця iнцидентностi графа g2:");
        int[,] incidenceMatrixG2 = g2.IncidenceMatrix();
        for (int i = 0; i < g2.V; i++)
        {
            for (int j = 0; j < incidenceMatrixG2.GetLength(1); j++)
            {
                Console.Write(incidenceMatrixG2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Хроматичне число графа g2: " + g2.ChromaticNumber());
        Console.WriteLine();
        Console.WriteLine("Реберне хроматичне число графа g2: " + g2.EdgeChromaticNumber());
        Console.WriteLine();

        Console.WriteLine("Пошук усiх ейлерових циклiв та ланцюгiв для графа g2:");
        List<List<int>> eulerianCircuitsAndPathsG2 = g2.FindEulerianCircuitsAndPaths();
        foreach (var circuitOrPath in eulerianCircuitsAndPathsG2)
        {
            Console.WriteLine(string.Join(" -> ", circuitOrPath.Select(v => v + 1)));
        }
        Console.WriteLine();

        Console.WriteLine("Алгоритм Дейкстри для графа g2:");
        g2.Dijkstra(0);
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань мiж будь-якою парою вершин для графа g2:");
        (source, destination) = g2.ShortestDistanceBetweenAnyTwoVerticesWithLongestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source + 1) + " та вершиною " + (destination + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("--------------------------------------------------------------------------------------");

        Graph g3 = new Graph(8);
        g3.AddEdge(1, 2, 1);
        g3.AddEdge(1, 4, 1);
        g3.AddEdge(1, 8, 3);
        g3.AddEdge(2, 3, 4);
        g3.AddEdge(2, 7, 2);
        g3.AddEdge(4, 5, 11);
        g3.AddEdge(5, 6, 2);
        g3.AddEdge(5, 8, 2);
        g3.AddEdge(6, 7, 2);
        g3.AddEdge(6, 8, 5);
        g3.AddEdge(7, 8, 1);

        Console.WriteLine("Лабораторна робота №5:");
        Console.WriteLine("Граф g3:");
        g3.PrintGraph();
        Console.WriteLine();

        Console.WriteLine("Матриця сумiжностi графа g3:");
        int[,] adjacencyMatrixG3 = g3.AdjacencyMatrix();
        for (int i = 0; i < g3.V; i++)
        {
            for (int j = 0; j < g3.V; j++)
            {
                Console.Write(adjacencyMatrixG3[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Матриця iнцидентностi графа g3:");
        int[,] incidenceMatrixG3 = g3.IncidenceMatrix();
        for (int i = 0; i < g3.V; i++)
        {
            for (int j = 0; j < incidenceMatrixG3.GetLength(1); j++)
            {
                Console.Write(incidenceMatrixG3[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Хроматичне число графа g3: " + g3.ChromaticNumber());
        Console.WriteLine();
        Console.WriteLine("Реберне хроматичне число графа g3: " + g3.EdgeChromaticNumber());
        Console.WriteLine();

        Console.WriteLine("Пошук усiх ейлерових циклiв та ланцюгiв для графа g3:");
        List<List<int>> eulerianCircuitsAndPathsG3 = g3.FindEulerianCircuitsAndPaths();
        foreach (var circuitOrPath in eulerianCircuitsAndPathsG3)
        {
            Console.WriteLine(string.Join(" -> ", circuitOrPath.Select(v => v + 1)));
        }
        Console.WriteLine();

        Console.WriteLine("Виконання DFS для графа g3:");
        bool[] visitedG3 = new bool[g3.V];
        g3.DepthFirstSearch(0, visitedG3);
        Console.WriteLine("\n");

        Console.WriteLine("Алгоритм Дейкстри для графа g3:");
        g3.Dijkstra(0);
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань мiж будь-якою парою вершин для графа g3:");
        (source, destination) = g3.ShortestDistanceBetweenAnyTwoVerticesWithShortestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source + 1) + " та вершиною " + (destination + 1) + ".");
        Console.WriteLine();
    }


}

class Graph
{
    public int V;
    private List<(int, int)>[] adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<(int, int)>[V];
        for (int i = 0; i < V; ++i)
        {
            adj[i] = new List<(int, int)>();
        }
    }

    public void PrintGraph()
    {
        for (int i = 0; i < V; i++)
        {
            Console.Write("Вершина " + (i + 1) + ": ");
            foreach ((int vertex, int weight) in adj[i])
            {
                Console.Write((vertex + 1) + "(" + weight + ") ");
            }
            Console.WriteLine();
        }
    }

    // Якщо граф неорiєнтований
    public void AddEdge(int v, int w, int weight)
    {
        v--; 
        w--; 
        adj[v].Add((w, weight));
        adj[w].Add((v, weight));
    }

    // Якщо граф орiєнтований
    public void AddEdgeOne(int v, int w, int weight)
    {
        v--; 
        w--; 
        adj[v].Add((w, weight));
    }

    // Матриця суміжності графа
    public int[,] AdjacencyMatrix()
    {
        int[,] matrix = new int[V, V];

        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                matrix[i, j] = 0; 
            }

            foreach ((int neighborVertexIndex, _) in adj[i])
            {
                matrix[i, neighborVertexIndex] = 1; 
            }
        }

        return matrix;
    }

    public int[,] IncidenceMatrix()
    {
        List<(int, int)> edges = new List<(int, int)>();
        Dictionary<(int, int), int> edgeIndexMap = new Dictionary<(int, int), int>();

        for (int i = 0; i < V; i++)
        {
            foreach ((int neighborVertexIndex, _) in adj[i])
            {
                if (!edgeIndexMap.ContainsKey((i, neighborVertexIndex)) && !edgeIndexMap.ContainsKey((neighborVertexIndex, i)))
                {
                    int edgeIndex = edges.Count;
                    edgeIndexMap[(i, neighborVertexIndex)] = edgeIndex;
                    edgeIndexMap[(neighborVertexIndex, i)] = edgeIndex; 
                    edges.Add((i, neighborVertexIndex));
                }
            }
        }

        int[,] matrix = new int[V, edges.Count];

        for (int i = 0; i < V; i++)
        {
            foreach ((int neighborVertexIndex, _) in adj[i])
            {
                int edgeIndex = edgeIndexMap[(i, neighborVertexIndex)];
                matrix[i, edgeIndex] = 1;
            }
        }

        return matrix;
    }


    public int ChromaticNumber()
    {
        Dictionary<int, int> colors = new Dictionary<int, int>();

        for (int v = 0; v < V; v++)
        {
            List<int> usedColors = new List<int>();

            foreach ((int neighborVertexIndex, _) in adj[v])
            {
                if (colors.ContainsKey(neighborVertexIndex))
                {
                    usedColors.Add(colors[neighborVertexIndex]);
                }
            }

            int minColor = 1;
            while (usedColors.Contains(minColor))
            {
                minColor++;
            }

            colors[v] = minColor;
        }

        return colors.Values.Max();
    }


    // Реберне хроматичне число графа
    public int EdgeChromaticNumber()
    {
        Dictionary<(int, int), int> edgeColors = new Dictionary<(int, int), int>();

        for (int v = 0; v < V; v++)
        {
            foreach ((int neighborVertexIndex, int _) in adj[v])
            {

                List<int> usedColors = new List<int>();
                foreach ((int u, int _) in adj[neighborVertexIndex])
                {
                    if (u != v && edgeColors.ContainsKey((neighborVertexIndex, u)))
                    {
                        usedColors.Add(edgeColors[(neighborVertexIndex, u)]);
                    }
                }

                int minColor = 1;
                while (usedColors.Contains(minColor))
                {
                    minColor++;
                }

                edgeColors[(v, neighborVertexIndex)] = minColor;
                edgeColors[(neighborVertexIndex, v)] = minColor;
            }
        }

        return edgeColors.Values.Max();
    }


    // Рекурсивна функцiя для знаходження Ейлерового шляху у графi
    private void EulerUtil(int v, bool[] visited, List<int> circuit)
    {
        foreach ((int u, int _) in adj[v])
        {
            if (!visited[u])
            {
                visited[u] = true;
                EulerUtil(u, visited, circuit);
            }
        }
        circuit.Add(v);
    }

    // Знаходження всiх Ейлерових ланцюгiв та циклiв
    public List<List<int>> FindEulerianCircuitsAndPaths()
    {
        List<List<int>> circuits = new List<List<int>>();

        for (int i = 0; i < V; i++)
        {
            List<int> circuit = new List<int>();
            bool[] visited = new bool[V];
            EulerUtil(i, visited, circuit);

            if (circuit[0] == circuit[circuit.Count - 1])
            {
                bool containsAllVertices = true;
                for (int j = 0; j < V; j++)
                {
                    if (!visited[j])
                    {
                        containsAllVertices = false;
                        break;
                    }
                }
                if (containsAllVertices)
                {
                    circuits.Add(circuit);
                }
            }
            else 
            {
                circuits.Add(circuit);
            }
        }

        return circuits;
    }

    public void DepthFirstSearch(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write((v + 1) + " ");

        foreach ((int u, int _) in adj[v])
        {
            if (!visited[u])
            {
                DepthFirstSearch(u, visited);
            }
        }
    }

    // Алгоритм Дейкстри для знаходження найкоротших вiдстаней вiд заданої вершини
    public void Dijkstra(int source)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
        }

        dist[source] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited);

            visited[u] = true;

            foreach ((int neighbor, int weight) in adj[u])
            {
                if (!visited[neighbor] && dist[u] != int.MaxValue && dist[u] + weight < dist[neighbor])
                {
                    dist[neighbor] = dist[u] + weight;
                }
            }
        }

        Console.WriteLine("Найкоротшi шляхи вiд вершини " + (source + 1) + ":");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine("Вершина " + (i + 1) + ": Вiдстань = " + dist[i]);
        }
    }

    // Допомiжна функцiя для знаходження вершини з мiнiмальною вiдстанню
    private int MinDistance(int[] dist, bool[] visited)
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

    // Метод, який знаходить найкоротшу відстань між будь-якою парою вершин згідно з найкоротшим шляхом
    public (int, int) ShortestDistanceBetweenAnyTwoVerticesWithShortestShortestDistance()
    {
        int shortestDistance = int.MaxValue;
        int sourceVertex = 0;
        int destinationVertex = 0;

        for (int i = 0; i < V; i++)
        {
            for (int j = i + 1; j < V; j++)
            {
                int distance = ShortestDistanceBetweenTwoVertices(i, j);
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    sourceVertex = i;
                    destinationVertex = j;
                }
            }
        }

        return (sourceVertex, destinationVertex);
    }

    // Метод, який знаходить найкоротшу відстань між будь-якою парою вершин
    public (int, int) ShortestDistanceBetweenAnyTwoVerticesWithLongestShortestDistance()
    {
        int longestShortestDistance = int.MinValue;
        int sourceVertex = 0;
        int destinationVertex = 0;

        for (int i = 0; i < V; i++)
        {
            for (int j = i + 1; j < V; j++)
            {
                int distance = ShortestDistanceBetweenTwoVertices(i, j);
                if (distance > longestShortestDistance)
                {
                    longestShortestDistance = distance;
                    sourceVertex = i;
                    destinationVertex = j;
                }
            }
        }

        return (sourceVertex, destinationVertex);
    }

    // Допоміжний метод для знаходження найкоротшого відстані між двома вершинами
    private int ShortestDistanceBetweenTwoVertices(int source, int destination)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
        }

        dist[source] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            foreach ((int neighbor, int weight) in adj[u])
            {
                if (!visited[neighbor] && dist[u] != int.MaxValue && dist[u] + weight < dist[neighbor])
                {
                    dist[neighbor] = dist[u] + weight;
                }
            }
        }

        return dist[destination];
    }

}
