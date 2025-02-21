using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Digite o valor do raio do círculo:");
            radius = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            area = (Math.Pow(radius, 2)) * 3.14159;
            Console.WriteLine($"A área do circulo de raio {radius} é igual a: {area.ToString("F4", CultureInfo.InvariantCulture)}");


        }
    }
}