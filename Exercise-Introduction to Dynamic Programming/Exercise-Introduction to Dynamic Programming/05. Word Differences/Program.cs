using System;

namespace _05._Word_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            var table = new int[str1.Length + 1, str2.Length + 1];
            for (int r = 1; r < table.GetLength(0); r++)
            {
                table[r, 0] = r;
            }
            for (int c = 1; c < table.GetLength(1); c++)
            {
                table[0, c] = c;
            }
            for (int r = 1; r < table.GetLength(0); r++)
            {
                for (int c = 1; c < table.GetLength(1); c++)
                {
                    if (str1[r-1]==str2[c-1])
                    {
                        table[r, c] = table[r - 1, c - 1];
                    }
                    else
                    {
                        table[r, c] = Math.Min(table[r, c - 1],table[r-1,c])+1;
                    }
                }
            }
            Console.WriteLine($"Deletions and Insertions: {table[str1.Length, str2.Length]}");
        }
    }
}
