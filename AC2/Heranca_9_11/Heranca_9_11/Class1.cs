using System;

// Criação da classe
	class Conta
	{
	// Criação das variaveis
		public int Numero { get; private set; }
		public string Titular { get; private set; }
	// Criação da variavel com protected
		public double Saldo { get; protected set; }
	// criação de construtores
		public Conta() { }
		public Conta(int numero, string titular, double saldo)
		{
			Numero = numero; Titular = titular; Saldo = saldo;
		}
	// métodos, saque e depósito
		public void Saque(double saldoTotal)
		{
			Saldo -= saldoTotal;
		}

		public void Deposito(double saldoTotal)
		{
			Saldo += saldoTotal;
		}
}
