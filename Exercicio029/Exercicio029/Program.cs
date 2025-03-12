using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Exercicio029
{
    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student();

            Console.Write("Enter the student's name: ");
            x.Name = Console.ReadLine()!;
            Console.Write("First score: ");
            x.Score1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Second score: ");
            x.Score2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Third score: ");
            x.Score3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            if (x.Approved())
            {
                Console.WriteLine($"Final Score: {x.FinalScore().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine($"Final Score: {x.FinalScore().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Failed");
                Console.WriteLine($"{x.Failed().ToString("F2", CultureInfo.InvariantCulture)} points missing!");
            }
        }
    }
}