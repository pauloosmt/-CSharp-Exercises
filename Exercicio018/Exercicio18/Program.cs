using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;
            Console.Write("Enter the number: ");
            x = int.Parse(Console.ReadLine()!);

            for (i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}