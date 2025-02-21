using System;
using System.Globalization;


namespace Exercicio021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            double x1, x2;
            Console.Write("Enter the number of pairs: ");
            n = int.Parse(Console.ReadLine()!);

            for (i = 1; i <= n; i++)
            {
                string[] pair = Console.ReadLine()!.Split(' ');
                x1 = int.Parse(pair[0]);
                x2 = int.Parse(pair[1]);
                if (x2 == 0)
                {
                    Console.WriteLine("Impossible division!!!");
                }
                else
                {
                    double div = (x1 / x2);
                    Console.WriteLine($"Division: {div.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}