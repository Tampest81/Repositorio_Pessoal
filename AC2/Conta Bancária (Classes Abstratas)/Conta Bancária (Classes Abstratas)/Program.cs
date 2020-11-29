using System;
using System.Collections.Generic; // library para a utilização das listas
class Program 
{
    static void Main(string[] args) 
    {
        List<Conta> list = new List<Conta>(); // criação da lista list utilizando os parametros da Conta
        list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01)); // adições á lista
        list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
        list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
        list.Add(new ContaJuridica(1002, "Mae", 500.0, 400.0));
        double soma = 0.0; // variavel soma
        foreach (Conta acc in list) // foreach para aplicar a conta a baixo em todas as instancias da lista
        {
            soma += acc.Saldo;
        }
        Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString()); // escreverá na tela a atualização das contas
        foreach (Conta acc in list) // foreach que mostrará o saque de todas as contas
        {
            acc.Saque(10.0);
        }
        foreach (Conta acc in list) // foreach que atualizará o saldo das contas
        {
            Console.WriteLine("Atualização do saldo das contas "
            + acc.Numero + ": " + acc.Saldo.ToString());
        }

    }
}
    