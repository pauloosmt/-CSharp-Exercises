using System;
using System.Globalization;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter the coordinate 'x' and 'y' respectively: ");
            string[] value = Console.ReadLine()!.Split(' ');
            x = double.Parse(value[0], CultureInfo.InvariantCulture);
            y = double.Parse(value[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origin");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0)
            {
                Console.WriteLine("Axle Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Axle X");
            }
        }
    }
}