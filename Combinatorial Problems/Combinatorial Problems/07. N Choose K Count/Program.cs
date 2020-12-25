﻿using System;
using System.Numerics;

namespace _07._N_Choose_K_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger count = CalculateFactorial(n) / (CalculateFactorial(n - k) * CalculateFactorial(k));

            Console.WriteLine(count);
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
