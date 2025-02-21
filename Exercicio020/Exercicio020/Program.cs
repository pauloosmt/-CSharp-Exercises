using System;
using System.Globalization;

namespace Exercicio020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            double x1, x2, x3, aver;
            Console.Write("Enter the number of times: ");
            n = int.Parse(Console.ReadLine()!);

            for (i = 1; i <= n; i++)
            {
                string[] val = Console.ReadLine()!.Split(' ');
                x1 = double.Parse(val[0], CultureInfo.InvariantCulture) * 2;
                x2 = double.Parse(val[1], CultureInfo.InvariantCulture) * 3;
                x3 = double.Parse(val[2], CultureInfo.InvariantCulture) * 5;

                aver = (x1 + x2 + x3) / 10;
                Console.WriteLine($"Average: {aver.ToString("F1", CultureInfo.InvariantCulture)}");

            }
        }
    }
}