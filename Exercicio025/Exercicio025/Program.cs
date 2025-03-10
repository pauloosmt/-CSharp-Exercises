using System;
using Exercicio025;

namespace exercicio025
{
    class Program
    {
        static void Main(string[] args)
        {
            Person x, y;
            x = new Person();
            y = new Person();

            Console.WriteLine("Enter the name and age of the 1 person: ");
            x.Name = Console.ReadLine()!;
            x.Age = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the name and age of the 2 person: ");
            y.Name = Console.ReadLine()!;
            y.Age = int.Parse(Console.ReadLine()!);

            if (x.Age > y.Age)
            {
                Console.WriteLine($"Older person: {x.Name}");
            }
            else if (y.Age > x.Age)
            {
                Console.WriteLine($"Older person: {y.Name}");
            }
            else
            {
                Console.WriteLine("They are the same age");
            }

        }
    }
}