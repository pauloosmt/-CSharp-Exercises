using System;
using System.Drawing;
using System.Globalization;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangle, circle, trapeze, square, rectangle;
            Console.WriteLine("enter the measurement 'A'");
            a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("enter the measurement 'B'");
            b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("enter the measurement 'C'");
            c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            triangle = (a * c) / 2;
            circle = (Math.Pow(c, 2)) * 3.14159;
            trapeze = ((a + b) * c) / 2;
            square = Math.Pow(b, 2);
            rectangle = a * b;

            Console.WriteLine($"Triangle: {triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circle: {circle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapeze: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Square: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Rectangle: {rectangle.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
