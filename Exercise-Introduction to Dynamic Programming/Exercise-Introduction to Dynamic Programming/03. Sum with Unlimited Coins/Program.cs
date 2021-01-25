using System;
using System.Linq;

namespace _03._Sum_with_Unlimited_Coins
{
    class Program
    {
        private static int targetSum;
        private static int[] coins;
        private static int totalSums;

        public static void Main(string[] args)
        {

            coins = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            targetSum = int.Parse(Console.ReadLine());
            totalSums = 0;
            CalculatePossibleSums(0, 0);
            Console.WriteLine(totalSums);
        }

        private static void CalculatePossibleSums(int sum, int start)
        {
            if (sum == targetSum)
            {
                totalSums++;
                return;
            }
            if (sum > targetSum)
            {
                return;
            }

            for (int i = start; i < coins.Length; i++)
            {
                CalculatePossibleSums(sum + coins[i], i);
            }
        }
    }
}
