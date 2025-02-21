using System;
using System.Globalization;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Enter the values 'X' and 'Y', respectively:");
            string[] values = Console.ReadLine()!.Split(' ');
            x = double.Parse(values[0], CultureInfo.InvariantCulture);
            y = double.Parse(values[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("First");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Second");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Third");
                }
                else
                {
                    Console.WriteLine("Fourth");
                }

                Console.WriteLine("Enter other values: ");
                values = Console.ReadLine()!.Split(' ');
                x = double.Parse(values[0], CultureInfo.InvariantCulture);
                y = double.Parse(values[1], CultureInfo.InvariantCulture);
            }
        }
    }
}