using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the number: ");
            x = int.Parse(Console.ReadLine()!);

            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            
            else
            {
                Console.WriteLine("Ímpar");
            }

        }
    }
}