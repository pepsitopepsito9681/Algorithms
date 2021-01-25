using System;

namespace _01._TBC
{
    class Program
    {
        private static bool[,] used;
        private static char[,] matrix;

        static void Dfs(int i, int j)
        {
            used[i, j] = true;

            // Up
            if (i - 1 >= 0 && matrix[i - 1, j] == 't' && !used[i - 1, j])
            {
                Dfs(i - 1, j);
            }


            // Down
            if (i + 1 < matrix.GetLength(0) && matrix[i + 1, j] == 't' && !used[i + 1, j])
            {
                Dfs(i + 1, j);
            }

            // Right
            if (j + 1 < matrix.GetLength(1) && matrix[i, j + 1] == 't' && !used[i, j + 1])
            {
                Dfs(i, j + 1);
            }

            // Left
            if (j - 1 >= 0 && matrix[i, j - 1] == 't' && !used[i, j - 1])
            {
                Dfs(i, j - 1);
            }

            // UpRight
            if (i - 1 >= 0 && j + 1 < matrix.GetLength(1) && matrix[i - 1, j + 1] == 't' && !used[i - 1, j + 1])
            {
                Dfs(i - 1, j + 1);
            }


            // UpLeft
            if (i - 1 >= 0 && j - 1 >= 0 && matrix[i - 1, j - 1] == 't' && !used[i - 1, j - 1])
            {
                Dfs(i - 1, j - 1);
            }

            // DownRight
            if (i + 1 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1) && matrix[i + 1, j + 1] == 't' && !used[i + 1, j + 1])
            {
                Dfs(i + 1, j + 1);
            }

            // DownLeft
            if (i + 1 < matrix.GetLength(0) && j - 1 >= 0 && matrix[i + 1, j - 1] == 't' && !used[i + 1, j - 1])
            {
                Dfs(i + 1, j - 1);
            }
        }

        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            matrix = new char[r, c];
            used = new bool[r, c];

            for (int i = 0; i < r; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int counter = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (!used[i, j] && matrix[i, j] == 't')
                    {
                        Dfs(i, j);
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
