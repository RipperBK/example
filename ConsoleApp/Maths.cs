using System;

namespace ConsoleApp
{
    public class Maths
    {
        public double Factorial(int n)
        {
            //if (n<=1)
            //{
            //    return 1;
            //}
            //return n * Factorial(n - 1);
            return n <= 1 ? 1 : n * Factorial(n - 1);
        }

        public static int[] Fibonacci(int limit)
        {
            int[] sequence = new int[limit];


            int f1 = 1, f2 = 1, count = 0;
            for (int fn = 0; count < limit ; fn = f1 + f2)
            {
                f1 = f2;
                f2 = fn;

                sequence[count++] = fn;
            }

            return sequence;
        }
    }
}