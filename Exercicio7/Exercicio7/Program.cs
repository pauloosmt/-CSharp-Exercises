using System;

namespace Exercicio7 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the number: ");
            x = int.Parse(Console.ReadLine()!);

            if (x < 0)
            {
                Console.WriteLine("Negative");
            }

            else
            {
                Console.WriteLine("Positive");
            }

        }
    }

}