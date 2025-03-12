using System;
using System.Globalization;

namespace Exercicio028
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee x = new Employee();

            Console.WriteLine("Enter the employee data: ");
            Console.Write("Name: ");
            x.Name = Console.ReadLine()!;
            Console.Write("Gross salary: R$");
            x.Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Tax: R$");
            x.Tax = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Employee: {x}");
            Console.WriteLine();

            Console.Write("Enter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.AddSalary(percentage);

            Console.WriteLine();
            Console.WriteLine($"Updated data: {x}");
        }
    }
}