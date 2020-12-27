using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Shortest_Path
{
    class Program
    {
        private static List<int>[] graph;
        private static bool[] visited;
        private static int[] parents;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            graph = ReadGraph(n, e);
            visited = new bool[graph.Length];
            parents = new int[graph.Length];
            Array.Fill(parents, -1);
            int source = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());
            
                BFS(source,destination);
            
        }

        private static void BFS(int startNode,int destination)
        {
            if (visited[startNode])
            {
                return;
            }
            var queue = new Queue<int>();
            queue.Enqueue(startNode);
            visited[startNode] = true;
            while (queue.Count>0)
            {
                int node = queue.Dequeue();
                if (node==destination)
                {
                    var path = ReconstructPath(destination);
                    Console.WriteLine($"Shortest path length is: {path.Count-1}");
                    Console.WriteLine(string.Join(" ",path));
                        return;
                }
                foreach (var child in graph[node])
                {
                    if (!visited[child])
                    {
                        parents[child] = node;
                        queue.Enqueue(child);
                        visited[child] = true;
                    }
                }
            }
        }

        private static Stack<int> ReconstructPath(int destination)
        {
            var path = new Stack<int>();
            int index = destination;
            while (index!=-1)
            {
                path.Push(index);
                index = parents[index];
            }
            return path;
        }

        private static List<int>[] ReadGraph(int n, int e)
        {
            var result = new List<int>[n + 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new List<int>();
            }
            for (int i = 0; i < e; i++)
            {
                var edge = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int from = edge[0];
                int to = edge[1];
                if (result[from]==null)
                {
                    result[from] = new List<int>();
                }
                result[from].Add(to);
            }
            return result;
        }
    }
}
