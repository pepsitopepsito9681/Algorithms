using System;

namespace _04._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        private static long Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
