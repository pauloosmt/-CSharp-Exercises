using System;

namespace Exercicio023
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter the number: ");
            x = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}