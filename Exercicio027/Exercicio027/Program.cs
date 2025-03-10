using System;
using System.Globalization;

namespace Exercicio027
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle x = new Rectangle();

            Console.Write("Enter the width of the rectangle: ");
            x.Width = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Enter the height of the rectangle: ");
            x.Height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Area: {x.Area().ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimeter: {x.Perimeter().ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {x.Diagonal().ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}