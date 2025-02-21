using System;
using System.Globalization;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1, p2;
            int n1, n2;
            double v1, v2, vt;

            Console.WriteLine("Digite o código da roupa, o número de peças e o valor unitário, respectivamente:");
            p1 = Console.ReadLine()!.Split(' ');
            Console.WriteLine("Digite o código da roupa, o número de peças e o valor unitário, respectivamente:");
            p2 = Console.ReadLine()!.Split(' ');
            n1 = int.Parse(p1[1]);
            v1 = double.Parse(p1[2], CultureInfo.InvariantCulture);
            n2 = int.Parse(p2[1]);
            v2 = double.Parse(p2[2], CultureInfo.InvariantCulture);

            vt = (n1 * v1) + (n2 * v2);

            Console.WriteLine($"O valor total da compra deu: R${vt.ToString("F2", CultureInfo.InvariantCulture)}");




        }
    }
}

