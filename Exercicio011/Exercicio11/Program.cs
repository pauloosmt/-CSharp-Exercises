using System;
using System.Globalization;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            double price = 0;
            Console.WriteLine("Digite o código do item e depois a quantidade necessária: ");
            string[] x =  Console.ReadLine()!.Split(' ');
            int code = int.Parse(x[0]);
            int amount = int.Parse(x[1]);


            if (code == 1)
            {
                double value = 4.0;
                price = value * amount;
            }
            else if (code == 2)
            {
                double value = 4.5;
                price = value * amount;
            }
            else if (code == 3)
            {
                double value = 5;
                price = value * amount;
            }
            else if (code == 4)
            {
                double value = 2.0;
                price = value * amount;

            }
            else if (code == 5)
            {
                double value = 1.5;
                price = value * amount;
            }
            Console.WriteLine($"O total a pagar sera de: R${price.ToString("F2", CultureInfo.InvariantCulture )}");

        }
    }
}
