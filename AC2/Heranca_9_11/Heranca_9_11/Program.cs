using System;

namespace Heranca_9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //colocando os valores no construtor em sua ordem respectiva
            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);
            // pedir para o console escrever o resultado do método saldo, derivado de conta.
            Console.WriteLine(conta.Saldo);
        }
    }
}
