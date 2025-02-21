using System;

namespace Exericio024
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
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
