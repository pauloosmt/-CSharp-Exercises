/* Projeto de uma simulação de conta bancaria, onde o usuario informa: o numero da conta, o nome da conta,
 e se deseja ou não realizar um saque inicial. Foi utlizado uma classe para criar o objeto da conta e também métodos simples
de encapsulamento.

Bank account simulation project, where the user informs: the account number, the account name, 
and whether or not he/she wishes to make an initial withdrawal. A class was used to create the account object and also simple 
encapsulation methods. */


using System.Globalization;

namespace Exercicio031
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount user;

            Console.WriteLine("========================");
            Console.WriteLine("NATIONAL BANK");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.Write("Enter  the account number: ");
            int number = int.Parse(Console.ReadLine()!);


            Console.Write("Enter the account holder: ");
            string name = Console.ReadLine()!;

            Console.Write("Do you want to make an initial deposit (s/n)? ");
            char resp = char.Parse(Console.ReadLine()!);

            if (resp == 's' || resp == 'S')
            {

                Console.Write("What is the initial deposit? R$");
                double balance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                user = new BankAccount(number, name, balance);

            }
            else
            {
                user = new BankAccount(number, name);
            }

            Console.WriteLine();
            Console.WriteLine("Account data: ");
            Console.WriteLine(user);

            Console.WriteLine();
            Console.Write("Enter an amount to deposit: R$");
            double dep = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            user.Deposit(dep);

            Console.WriteLine();
            Console.WriteLine("Updated account data: ");
            Console.WriteLine(user);

            Console.WriteLine();
            Console.Write("Enter an amount to withdraw: R$");
            double wd = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            user.WithDraw(wd);

            Console.WriteLine();
            Console.WriteLine("Updated account data: ");
            Console.WriteLine(user);
            
        }

    }
}