using System;
using System.Globalization;


namespace Exercicio028
{
    class Employee
    {
        public string Name;
        public double Salary;
        public double Tax;


        public double NetSalary()
        {
            return Salary - Tax;
        }

        public void AddSalary(double percentage)
        {
            Salary += (Salary * percentage) / 100;
        }

        public override string ToString()
        {
            return ($"{Name}, R${NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
