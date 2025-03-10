using System;
using System.Globalization;

namespace Exercicio026
{
    class Program
    {
        static void Main(string[] args) 
        {
            Employee x, y;
            x = new Employee();
            y = new Employee();

            Console.WriteLine("Enter the name and salary of the 1 person: ");
            x.Name = Console.ReadLine()!;
            x.Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the name and salary of the 2 person: ");
            y.Name = Console.ReadLine()!;
            y.Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double avg  = (x.Salary + y.Salary) / 2;

            Console.WriteLine($"Average salary: {avg.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}