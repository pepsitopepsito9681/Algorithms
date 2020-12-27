using System;
using System.Linq;

namespace _06._Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sorted = MergeSort(numbers);
            Console.WriteLine(string.Join(" ",sorted));
        }

        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length<=1)
            {
                return numbers;
            }
            var left = numbers.Take(numbers.Length / 2).ToArray();
            var right = numbers.Skip(numbers.Length / 2).ToArray();
            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var merged = new int[left.Length + right.Length];
            int mergedIdx = 0;
            int leftIdx = 0;
            int rightIdx = 0;
            while (leftIdx < left.Length && rightIdx < right.Length)
            {


                if (left[leftIdx] < right[rightIdx])
                {
                    merged[mergedIdx] = left[leftIdx];
                    leftIdx += 1;
                }
                else
                {
                    merged[mergedIdx] = right[rightIdx];
                    rightIdx += 1;
                }
                mergedIdx += 1;
            }
            while (leftIdx<left.Length)
            {
                
                    merged[mergedIdx] = left[leftIdx];
                    leftIdx += 1;
                
                mergedIdx += 1;
            }
            while (rightIdx < right.Length)
            {

                merged[mergedIdx] = right[rightIdx];
                rightIdx += 1;

                mergedIdx += 1;
            }
            return merged;
        }
    }
}
