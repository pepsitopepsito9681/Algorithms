﻿using System;
using System.Linq;

namespace _04._Variations_with_Repetition
{
    class Program
    {
        static char[] set;
        static char[] variation;

        static void Main(string[] args)
        {
            set = Console.ReadLine()
                .Split()
                .Select(Char.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());

            variation = new char[k];

            Variate(0);
        }

        public static void Variate(int index)
        {
            if (index >= variation.Length)
            {
                Console.WriteLine(string.Join(" ", variation));
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    variation[index] = set[i];
                    Variate(index + 1);
                }
            }
        }
    }
}
