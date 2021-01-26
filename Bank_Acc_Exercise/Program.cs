using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicio0
{
    class ContaBancária
    {
        static void Main(string[] args)
        {
            string titular;
            int número;
            double dep;

            Console.Write("Insira o nome do titular:");
            titular = Console.ReadLine();

            Console.Write("Insira o número da Conta:");
            número = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja realizar um depósito inicial? y/n");
            string ini = Console.ReadLine();

            Conta x = new Conta(titular, número, 0);

            System.Console.WriteLine(x);

            if (ini == "y")
            {
                Console.Write("Insira o valor a ser depositado:");
                dep = double.Parse(Console.ReadLine());
                _ = new Conta(dep);
                Console.WriteLine(x);
            }

            Console.WriteLine(x);
        }

    }
}

