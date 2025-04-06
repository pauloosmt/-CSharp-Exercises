using System.Globalization;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Cryptography;

namespace Exercicio033
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("How many employees will be registered?: ");
            n = int.Parse(Console.ReadLine()!);

            List<Employee> user = new List<Employee>(); // lista criando objetos que virao a ser funcionarios

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine()!);
                Console.WriteLine();

                user.Add(new Employee { Id = id, Name = name, Salary = salary }); //instanciando a lista para criar novos usuarios e adiciona-los

            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int id_incr = int.Parse(Console.ReadLine()!); 
            

            Employee emp = user.Find(x => x.Id == id_incr)!; //conferindo se o id informado tem algum funcionário vinculado

            if(emp != null) //se o emp encontrar um id diferente de nulo
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } 
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in user)
            {
                Console.WriteLine(obj);
            }

        }
    }
}