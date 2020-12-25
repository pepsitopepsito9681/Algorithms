﻿using System;

namespace _03._Combinations_with_Repetition
{
    class Program
    {
        private static int[] arr;

        static void Main(string[] args)
        {
            int setCount = int.Parse(Console.ReadLine());
            int loopsCount = int.Parse(Console.ReadLine());
            arr = new int[loopsCount];
            Combinations(setCount);
        }

        static void Combinations(int setCount, int index = 0, int element = 1)
        {
            if (index >= arr.Length)
            {
                Print(arr);
                return;
            }

            for (int i = element; i <= setCount; i++)
            {
                arr[index] = i;
                Combinations(setCount, index + 1, i);
            }
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
