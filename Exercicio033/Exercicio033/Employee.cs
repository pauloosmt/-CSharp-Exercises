﻿using System;
using System.Globalization;


namespace Exercicio033
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * percentage) / 100;
        }



        public override string ToString()
        {
            return $"{Id}: {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
