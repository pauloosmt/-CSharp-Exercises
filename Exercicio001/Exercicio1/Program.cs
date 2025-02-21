using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Escreva outro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"A soma dos dois números será: {n1 + n2}");

        }
    }
}