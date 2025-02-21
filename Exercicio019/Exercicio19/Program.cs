using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, values, _in, _out;
            Console.Write("Enter the number of values: ");
            n = int.Parse(Console.ReadLine()!);
            _in = 0;
            _out = 0;


            for (i = 1; i <= n; i++)
            {
                Console.Write($"Enter the {i} value: ");
                values = int.Parse(Console.ReadLine()!);
                if (values >= 10 && values <=20)
                {
                    _in ++;
                }
                else
                {
                    _out++;
                }
            }
            Console.WriteLine($"{_in} in");
            Console.WriteLine($"{_out} out");
        }
    }
}