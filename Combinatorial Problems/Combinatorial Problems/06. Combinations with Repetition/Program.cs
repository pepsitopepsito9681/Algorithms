﻿using System;
using System.Linq;

namespace _06._Combinations_with_Repetition
{
    class Program
    {
        static char[] set;
        static char[] combination;

        static void Main(string[] args)
        {
            set = Console.ReadLine()
                .Split()
                .Select(Char.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());
            combination = new char[k];

            Combinate(0, 0);
        }

        private static void Combinate(int index, int start)
        {
            if (index >= combination.Length)
            {
                Console.WriteLine(String.Join(" ", combination));
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    combination[index] = set[i];
                    Combinate(index + 1, i);
                }
            }
        }
    }
}
