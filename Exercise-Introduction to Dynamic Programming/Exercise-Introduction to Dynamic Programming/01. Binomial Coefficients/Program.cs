using System;

namespace _01._Binomial_Coefficients
{
    class Program
    {
        static long[][] coefficients;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            coefficients = new long[n + 1][];
            coefficients[0] = new long[] { 1 };

            long result = GetBinomialCoefficients(n, k);
            Console.WriteLine(result);
        }

        static long GetBinomialCoefficients(int n, int k)
        {
            if (coefficients[n] == null)
            {
                coefficients[n] = new long[n + 1];
            }

            if (k < 0 || k >= coefficients[n].Length)
            {
                return 0;
            }

            if (coefficients[n][k] != 0)
            {
                return coefficients[n][k];
            }

            long coef = GetBinomialCoefficients(n - 1, k - 1) + GetBinomialCoefficients(n - 1, k);
            coefficients[n][k] = coef;
            return coef;
        }
    }
}
