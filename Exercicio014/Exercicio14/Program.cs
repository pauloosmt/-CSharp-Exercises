using System;
using System.Globalization;

namespace Exercico14
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary, tax;
            Console.WriteLine("Enter the salary: ");
            salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            salary.ToString("F2");

            if (salary <= 2000.0)
            {
                Console.WriteLine("Free");
            }
            else if (salary <= 3000.0)
            {
                tax = (salary - 2000) * 0.08;
                Console.WriteLine($"Tax: R${tax.ToString(CultureInfo.InvariantCulture)}");
            }
            else if (salary <= 4500)
            {
                tax = (salary - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine($"Tax: R${tax.ToString(CultureInfo.InvariantCulture)}");
            }
            else
            {
                tax = (salary - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
                Console.WriteLine($"Tax: R${tax.ToString(CultureInfo.InvariantCulture)}");
            }
        }
    }
}