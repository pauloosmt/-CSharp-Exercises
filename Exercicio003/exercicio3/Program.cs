using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hours;
            double value;

            Console.WriteLine("Enter your number: ");
            number = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the number of hours worked:");
            hours = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the amount you receive per hour:");
            value = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Salary: U${(hours * value).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}