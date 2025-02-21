using System;

namespace Exercicio17
{

    class Program
    {
        static void Main(string[] args)
        {
            int x, alcohol, gasoline, diesel;
            Console.Write("1.Alcohol 2.Gasoline 3.Diesel 4.End: ");
            x = int.Parse(Console.ReadLine()!);
            alcohol = 0;
            gasoline = 0;
            diesel = 0;

            while (x != 4)
            {
                if (x == 1)
                {
                    alcohol++;
                }
                else if (x == 2)
                {
                    gasoline++;
                }
                else if (x == 3)
                {
                    diesel++;
                }
                Console.Write("1.Alcohol 2.Gasoline 3.Diesel 4.End: ");
                x = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Thanks");
            Console.WriteLine($"Alcohol: {alcohol} \r\nGasoline: {gasoline} \r\nDiesel: {diesel}");
        }
    }
}