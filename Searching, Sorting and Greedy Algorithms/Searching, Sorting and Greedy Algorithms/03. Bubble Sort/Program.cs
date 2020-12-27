using System;
using System.Linq;

namespace _03._Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BubbleSort(numbers);
            Console.WriteLine(string.Join(" ",numbers));
        }

        private static void BubbleSort(int[] numbers)
        {
            bool isSorted = false;
            int sortedElementsCount = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int j = 1; j < numbers.Length- sortedElementsCount; j++)
                {
                    if (numbers[j-1]>numbers[j])
                    {
                        Swap(numbers, j - 1, j);
                        isSorted = false;
                    }
                }
            }
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            int temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
