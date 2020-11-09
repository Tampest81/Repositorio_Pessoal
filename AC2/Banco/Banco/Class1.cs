using Banco;
using System;
using System.Dynamic;

public class Class1
{//variaveis
		public int conta { get; set; }
		public string nome { get; set; }
		public string sn { get; set; }
		public double deposito { get; set; }

	    public double saldo;

	Program program = new Program();

	//metodos
	public void Att()
    {
        Console.WriteLine("Dados da conta: " +
		"Nº da Conta: " + conta +
		" /Nome do titular: " + nome + " //Saldo: " + saldo);
    }

	public void Deposito()
    {
		Console.WriteLine("Valor a ser depositado: ");
		deposito = double.Parse(Console.ReadLine());
		saldo = saldo + deposito;
    }

	public void Saque()
    {
		Console.WriteLine("Valor a para o saque: ");
		double saque = double.Parse(Console.ReadLine());
		saldo = saldo - (saque + 5);
    }

}
