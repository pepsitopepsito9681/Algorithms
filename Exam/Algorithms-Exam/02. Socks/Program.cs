using System;
using System.Linq;

namespace _02._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leftSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] rightSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] table = new int[leftSocks.Length + 1, rightSocks.Length + 1];

            int max = 0;

            for (int r = 1; r < table.GetLength(0); r++)
            {
                for (int c = 1; c < table.GetLength(1); c++)
                {
                    if (leftSocks[r - 1] == rightSocks[c - 1])
                    {
                        table[r, c] = table[r - 1, c - 1] + 1;
                    }
                    else
                    {
                        table[r, c] = Math.Max(table[r, c - 1], table[r - 1, c]);
                    }

                    if (table[r, c] > max)
                    {
                        max = table[r, c];
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
