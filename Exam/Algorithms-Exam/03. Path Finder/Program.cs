using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Path_Finder
{
    class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[,] graph = new bool[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                List<int> children = string.IsNullOrEmpty(line) ? new List<int>() : line.Split(' ').Select(int.Parse).ToList();

                foreach (int child in children)
                {
                    graph[i, child] = true;
                }
            }

            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < p; i++)
            {
                List<int> path = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                bool correct = true;

                for (int j = 1; j < path.Count; j++)
                {
                    if (!graph[path[j - 1], path[j]])
                    {
                        correct = false;
                    }
                }

                Console.WriteLine(correct ? "yes" : "no");
            }
        }
    }
}
