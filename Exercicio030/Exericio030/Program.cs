using System;
using System.Globalization;
using Exericio030;

namespace Exercicio030
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is the dollar exchange rate?: ");
            CurrencyConverter.Dollar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("How many dollars will you buy?: ");
            double quant = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Amount to be paid: R${CurrencyConverter.Converter(quant).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}