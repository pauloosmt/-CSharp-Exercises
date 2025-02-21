using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, val;
            Console.WriteLine("Digite um valor inteiro: ");
            a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite um valor inteiro: ");
            b = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite um valor inteiro: ");
            c = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite um valor inteiro: ");
            d = int.Parse(Console.ReadLine()!);

            val = (a * b) - (c * d);

            Console.WriteLine($"O resultado de ({a} * {b}) - ({c} * {d}) = {val}");
        }
    }
}