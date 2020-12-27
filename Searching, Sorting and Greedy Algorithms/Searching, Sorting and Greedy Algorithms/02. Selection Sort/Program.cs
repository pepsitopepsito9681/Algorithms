using System;
using System.Linq;

namespace _02._Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SelectionSort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            
        }

        private static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int minIdx = i;
                int minNumber = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j]<minNumber)
                    {
                        minNumber = numbers[j];
                        minIdx = j;
                    }
                }
                Swap(numbers, i, minIdx);
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
