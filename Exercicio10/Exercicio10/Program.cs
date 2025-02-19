using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            Console.WriteLine("when the game started: ");
            start = int.Parse(Console.ReadLine()!);
            Console.WriteLine("when the game finished: ");
            end = int.Parse(Console.ReadLine()!);

            if (start < end && end - start >= 1)
            {
                int duration = end - start;
                Console.WriteLine($"The game lasted: {duration} hours");
            }

            else if (start > end && (end + 24) - start >= 1)
            {
                int duration = (end + 24) - start;
                Console.WriteLine($"The game lasted: {duration} hours");
            }

            else
            {
                Console.WriteLine("The game lasted: 24 hours");
            }
        }
    }
}
