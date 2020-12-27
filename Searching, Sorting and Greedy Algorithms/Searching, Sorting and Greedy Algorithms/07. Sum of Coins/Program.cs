using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Sum_of_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var sortedCoins = new SortedSet<int>(coins);
            int target = int.Parse(Console.ReadLine());
            int result = 0;
            var sb = new StringBuilder();
            while (target>0&&sortedCoins.Count>0)
            {
                int maxCoin = sortedCoins.Max;
                sortedCoins.Remove(maxCoin);
                if (maxCoin>target)
                {
                    continue;
                }
                int counter = target / maxCoin;
                result += counter;
                target = target - maxCoin * counter;
                sb.AppendLine($"{counter} coin(s) with value {maxCoin}");
            }
            if (target>0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"Number of coins to take: {result}");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
