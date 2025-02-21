using System;

namespace Exercicio022
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Factorial: {fatorial(n)}");
        }

        static int fatorial(int a)
        {
            int x;
            x = a;
            int x1 = a;
            if (a != 0)
            {
                for (int i = 1; i < x1; x1 -= 1)
                {
                    x = x * (x1 - 1);
                }
            }
            else
            {
                x = 1;
            }
            return x;
        }
    }
}