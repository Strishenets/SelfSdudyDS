using System;
using System.Collections.Generic;
using System.IO;
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

        Console.WriteLine("Лабораторна робота №3: \n");
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

        Console.WriteLine("Матриця iнцидентностi графа:");
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

        Console.WriteLine("Хроматичне число графа: " + g1.ChromaticNumber());
        Console.WriteLine();
        Console.WriteLine("Реберне хроматичне число графа: " + g1.EdgeChromaticNumber());
        Console.WriteLine();


        Console.WriteLine("Виконання DFS для графа:");
        bool[] visitedG1 = new bool[g1.V];
        g1.DepthFirstSearch(0, visitedG1);
        Console.WriteLine("\n");

        Console.WriteLine("Алгоритм Дейкстри для графа:");
        g1.Dijkstra(0);
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань є найдовшою серед всiх найкоротших вiдстаней:");
        (int source1, int destination1) = g1.ShortestDistanceBetweenAnyTwoVerticesWithShortestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source1 + 1) + " та вершиною " + (destination1 + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань є найкоротшою серед всiх найкоротших вiдстаней:");
        (source1, destination1) = g1.ShortestDistanceBetweenAnyTwoVerticesWithLongestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source1 + 1) + " та вершиною " + (destination1 + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("Ейлеровi цикли:");
        var eulerCyclesG1 = g1.FindEulerianCycles();
        foreach (var cycle in eulerCyclesG1)
        {
            Console.WriteLine(string.Join(" -> ", cycle.Select(v => v + 1)));
        }


        Console.WriteLine("\nЕйлеровi ланцюги:");
        var eulerPathsG1 = g1.FindEulerianPaths();
        foreach (var path in eulerPathsG1)
        {
            Console.WriteLine(string.Join(" -> ", path.Select(v => v + 1)));
        }


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

        Console.WriteLine("Лабораторна робота №4:\n");
        g2.PrintGraph();
        Console.WriteLine();

        Console.WriteLine("Матриця сумiжностi графа:");
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

        Console.WriteLine("Матриця iнцидентностi графа:");
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

        Console.WriteLine("Хроматичне число графа: " + g2.ChromaticNumber());
        Console.WriteLine();
        Console.WriteLine("Реберне хроматичне число графа: " + g2.EdgeChromaticNumber());
        Console.WriteLine();

       
       

        Console.WriteLine("Виконання DFS для графа:");
        bool[] visitedG2 = new bool[g2.V];
        g2.DepthFirstSearch(0, visitedG2);
        Console.WriteLine("\n");

        Console.WriteLine("Алгоритм Дейкстри для графа:");
        g2.Dijkstra(0);
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань є найдовшою серед всiх найкоротших вiдстаней:");
        (int source2, int destination2) = g2.ShortestDistanceBetweenAnyTwoVerticesWithShortestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source2 + 1) + " та вершиною " + (destination2 + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань є найкоротшою серед всiх найкоротших вiдстаней:");
        (source2, destination2) = g2.ShortestDistanceBetweenAnyTwoVerticesWithLongestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source2 + 1) + " та вершиною " + (destination2 + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("Ейлеровi цикли графа g2:");
        var eulerCyclesG2 = g2.FindEulerianCycles();
        foreach (var cycle in eulerCyclesG2)
        {
            Console.WriteLine(string.Join(" -> ", cycle.Select(v => v + 1)));
        }

        Console.WriteLine("\nЕйлеровi ланцюги:");
        var eulerPathsG2 = g2.FindEulerianPaths();
        foreach (var path in eulerPathsG2)
        {
            Console.WriteLine(string.Join(" -> ", path.Select(v => v + 1)));
        }

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

        Console.WriteLine("Лабораторна робота №5:\n");
        g3.PrintGraph();
        Console.WriteLine();

        Console.WriteLine("Матриця сумiжностi графа:");
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

        Console.WriteLine("Матриця iнцидентностi графа:");
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

        Console.WriteLine("Хроматичне число графа: " + g3.ChromaticNumber());
        Console.WriteLine();
        Console.WriteLine("Реберне хроматичне число графа: " + g3.EdgeChromaticNumber());
        Console.WriteLine();

        
        

        Console.WriteLine("Виконання DFS для графа:");
        bool[] visitedG3 = new bool[g3.V];
        g3.DepthFirstSearch(0, visitedG3);
        Console.WriteLine("\n");

        Console.WriteLine("Алгоритм Дейкстри для графа:");
        g3.Dijkstra(0);
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань є найдовшою серед всiх найкоротших вiдстаней:");
        (int source3, int destination3) = g3.ShortestDistanceBetweenAnyTwoVerticesWithShortestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source3 + 1) + " та вершиною " + (destination3 + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("Найкоротша вiдстань є найкоротшою серед всiх найкоротших вiдстаней:");
        (source3, destination3) = g3.ShortestDistanceBetweenAnyTwoVerticesWithLongestShortestDistance();
        Console.WriteLine("Мiж вершиною " + (source3 + 1) + " та вершиною " + (destination3 + 1) + ".");
        Console.WriteLine();

        Console.WriteLine("Ейлеровi цикли графа g3:");
        var eulerCyclesG3 = g3.FindEulerianCycles();
        foreach (var cycle in eulerCyclesG3)
        {
            Console.WriteLine(string.Join(" -> ", cycle.Select(v => v + 1)));
        }


        Console.WriteLine("\nЕйлеровi ланцюги:");
        var eulerPathsG3 = g3.FindEulerianPaths();
        foreach (var path in eulerPathsG3)
        {
            Console.WriteLine(string.Join(" -> ", path.Select(v => v + 1)));
        }

    }


}

class Graph
{
    public int V;
    private List<(int, int)>[] adj;
    private List<List<int>> paths;

    public Graph(int v)
    {
        V = v;
        adj = new List<(int, int)>[V];
        for (int i = 0; i < V; ++i)
        {
            adj[i] = new List<(int, int)>();
        }
        paths = new List<List<int>>();
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

    public void AddEdge(int v, int w, int weight)
    {
        v--;
        w--;
        adj[v].Add((w, weight));
        adj[w].Add((v, weight));
    }

    public void AddEdgeOne(int v, int w, int weight)
    {
        v--;
        w--;
        adj[v].Add((w, weight));
    }

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

    public static int FindStartVertexForEulerianPath(Graph graph)
    {
        foreach (var vertex in graph.adj)
        {
            if (vertex.Count % 2 != 0)
            {
                return vertex.First().Item1;
            }
        }
        return 0; 
    }


    

    public bool AllVerticesHaveEvenDegree()
    {
        foreach (var vertex in adj)
        {
            if (vertex.Count % 2 != 0)
            {
                return false;
            }
        }
        return true;
    }

    public List<List<int>> FindEulerianCycles()
    {
        List<List<int>> cycles = new List<List<int>>();

        if (!IsEulerian())
        {
            Console.WriteLine("Граф не мiстить ейлерового циклу.");
            return cycles;
        }

        int startVertex = 0;
        while (adj[startVertex].Count == 0)
        {
            startVertex++;
        }

        Stack<int> stack = new Stack<int>();
        List<int> currentCycle = new List<int>();

        stack.Push(startVertex);
        while (stack.Count > 0)
        {
            int v = stack.Peek();

            if (adj[v].Count > 0) 
            {
                stack.Push(adj[v][0].Item1); 
                int neighborIndex = adj[v][0].Item1;

                adj[v].RemoveAt(0);
                foreach (var item in adj[neighborIndex])
                {
                    if (item.Item1 == v)
                    {
                        adj[neighborIndex].Remove(item);
                        break;
                    }
                }
            }
            else 
            {
                stack.Pop(); 
                currentCycle.Add(v);

                if (stack.Count == 0)
                {
                    cycles.Add(currentCycle);
                    currentCycle = new List<int>();

                    for (int i = startVertex; i < adj.Length; i++)
                    {
                        if (adj[i].Count > 0)
                        {
                            startVertex = i;
                            stack.Push(startVertex);
                            break;
                        }
                    }
                }
            }
        }

        return cycles;
    }

    public List<List<int>> FindEulerianPaths()
    {
        List<List<int>> paths = new List<List<int>>();

        if (!HasExactlyTwoOddDegreeVertices(this))
        {
            Console.WriteLine("Граф не мiстить Ейлерового ланцюга.");
            return paths;
        }

        int startVertex = FindStartVertexForEulerianPath(this);
        List<int> eulerianPath = new List<int>();

        DepthFirstSearchForEulerianPath(startVertex, eulerianPath);

        paths.Add(eulerianPath);

        return paths;
    }

    private void DepthFirstSearchForEulerianPath(int v, List<int> eulerianPath)
    {
        while (adj[v].Count > 0)
        {
            int neighbor = adj[v][0].Item1;
            adj[v].RemoveAt(0);
            for (int i = 0; i < adj[neighbor].Count; i++)
            {
                if (adj[neighbor][i].Item1 == v)
                {
                    adj[neighbor].RemoveAt(i);
                    break;
                }
            }
            DepthFirstSearchForEulerianPath(neighbor, eulerianPath);
        }

        eulerianPath.Insert(0, v);
    }

    public bool IsEulerian()
    {
        foreach (var vertex in adj)
        {
            if (vertex.Count % 2 != 0)
            {
                return false;
            }
        }

        bool[] visited = new bool[V];
        DepthFirstSearch(0, visited);
        for (int i = 0; i < V; i++)
        {
            if (!visited[i] && adj[i].Count > 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool HasExactlyTwoOddDegreeVertices(Graph graph)
    {
        int oddDegreeCount = 0;
        foreach (var vertex in graph.adj)
        {
            if (vertex.Count % 2 != 0)
            {
                oddDegreeCount++;
                if (oddDegreeCount > 2)
                {
                    return false;
                }
            }
        }
        return oddDegreeCount == 2;
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
                if (!visited[neighbor] && dist[u] != int.MaxValue && dist[neighbor] > dist[u] + weight)
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

    public (int, int) ShortestDistanceWithLongestShortestDistance()
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
}
