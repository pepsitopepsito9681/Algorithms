﻿using System;

namespace _02._Nested_Loops
{
    class Program
    {
        private static int[] loops;

        static void Main(string[] args)
        {
            int loopsCount = int.Parse(Console.ReadLine());
            loops = new int[loopsCount];
            NestedLoops(loopsCount, 0);
        }

        static void NestedLoops(int loopsCount, int currentLoop)
        {
            if (currentLoop == loopsCount)
            {
                Print(loops);
                return;
            }

            for (int counter = 1; counter <= loopsCount; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(loopsCount, currentLoop + 1);
            }
        }

        private static void Print(int[] loops)
        {
            Console.WriteLine(String.Join(" ", loops));
        }
    }
}
