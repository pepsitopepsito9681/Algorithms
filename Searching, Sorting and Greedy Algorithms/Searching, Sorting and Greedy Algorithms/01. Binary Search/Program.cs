using System;
using System.Linq;

namespace _01._Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbers,number));
        }
        private static int BinarySearch(int[] arr,int number)
        {
            int startIdx = 0;
            int endIdx = arr.Length - 1;
            while (startIdx<=endIdx)
            {
                int midIdx = (startIdx + endIdx) / 2;
                if (arr[midIdx]==number)
                {
                    return midIdx;
                }
                if (number>arr[midIdx])
                {
                    startIdx = midIdx + 1;
                }
                else
                {
                    endIdx = midIdx - 1;
                }
            }
            return -1;
        }
    }
}
