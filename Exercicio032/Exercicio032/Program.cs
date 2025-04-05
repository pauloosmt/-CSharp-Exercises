
using System.Numerics;

namespace Exercicio032
{
    class Program
    {
        static void Main(string[] args)
        {
            Bedrooms[] bedrooms = new Bedrooms[10]; //criando 10 quartos

            Console.Write("How many students will rent?: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                bedrooms[room] = new Bedrooms { Name = name, Email = email, Room = room };  //pegando o numero do quarto que o usuario deseja e alocando-o na mesma posição
            }


            for (int i = 0; i < 10; i++)
            {
                if (bedrooms[i] != null)
                {
                    Console.WriteLine(bedrooms[i]);
                }
                
            }
        }
    }
}