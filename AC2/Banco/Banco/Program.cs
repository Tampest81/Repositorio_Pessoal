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
            Info.conta = int.Parse(Console.ReadLine()); // pega a variavel do getset da classe e aplica um valor dado pelo usuario

            Console.Write("Nome do Titular: ");
            Info.nome = Console.ReadLine(); // pega a variavel do getset da classe e aplica um valor dado pelo usuario

            Console.WriteLine("Haverá Depósito inicial? S/N");
            Info.sn = Console.ReadLine(); // pega a variavel do getset da classe e aplica um valor dado pelo usuario
            Info.sn.ToUpper(); // sempre deixará a stirng dada (SN) sempre maiuscula
            if(Info.sn == "S")// condição para o deposito
            {
                Console.WriteLine("Valor a ser depositado: ");
                Info.deposito = double.Parse(Console.ReadLine());
                Info.saldo = Info.deposito;
            }


            //métodos
            Info.Att(); // método que irá atualizar os dados

            Info.Deposito(); // método que irá perguntar se irá realizar o deposito

            Info.Att(); // método que irá atualizar os dados

            Info.Saque(); // método que irá perguntar se irá realizar o saque

            Info.Att(); // método que irá atualizar os dados

            Console.ReadKey();
        }
    }
}
