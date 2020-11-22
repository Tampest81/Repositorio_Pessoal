using System;

// criação da classe2
	class ContaJuridica : Conta // herança da classe conta para a classe conta juridica
	{
	// criação da variavel
		public double EmprestimoLimite { get; set; }
	// criação de construtores
		public ContaJuridica() { }
	// criação de construtores com as variaveis da classe conta
		public ContaJuridica
		(int numero, string titular, double saldo, double emprestimoLimite)
		: base(numero, titular, saldo)
		{
			EmprestimoLimite = emprestimoLimite;
		}
	// método emprestimo
		public void Emprestimo(double saldoTotal)
		{
			if (saldoTotal <= EmprestimoLimite)
			{
				Saldo += saldoTotal;
			}
		}
	}

