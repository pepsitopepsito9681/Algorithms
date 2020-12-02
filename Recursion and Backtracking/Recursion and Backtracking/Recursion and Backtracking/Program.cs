using System;
using System.Linq;

namespace Recursion_and_Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(numbers, 0));
        }

        private static int Sum(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + Sum(numbers, ++index);
        }
    }
}
