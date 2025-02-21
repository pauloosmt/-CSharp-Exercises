using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter the number: ");
            a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter other number: ");
            b = int.Parse(Console.ReadLine()!);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("are multiple");
            }
            else
            {
                Console.WriteLine("they aren't multiple");
            }
        }
    }
}

