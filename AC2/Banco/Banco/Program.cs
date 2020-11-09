using System;
using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe
            Class1 Info = new Class1();

            Console.Write("Numero da conta: ");
            Info.conta = int.Parse(Console.ReadLine());

            Console.Write("Nome do Titular: ");
            Info.nome = Console.ReadLine();

            Console.WriteLine("Haverá Depósito inicial? S/N");
            Info.sn = Console.ReadLine();
            Info.sn.ToUpper();
            if(Info.sn == "S")// condição para o deposito
            {
                Console.WriteLine("Valor a ser depositado: ");
                Info.deposito = double.Parse(Console.ReadLine());
                Info.saldo = Info.deposito;
            }


            //métodos
            Info.Att();

            Info.Deposito();

            Info.Att();

            Info.Saque();

            Info.Att();

            Console.ReadKey();
        }
    }
}
