using System;

namespace _03._Generating_0_or_1_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var vector = new int[n];

            Gen01(vector, 0);
        }

        private static void Gen01(int[] vector, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Concat(vector));
            }
            else
            {
                vector[index] = 0;
                Gen01(vector, index + 1);

                vector[index] = 1;
                Gen01(vector, index + 1);
            }
        }
    }
}
