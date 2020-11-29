using System;

class ContaJuridica : Conta// herança da classe conta
{
    public double EmprestimoLimite { get; set; } // getset da variavel emprestimo limite
    public ContaJuridica() { } // construtor
    public ContaJuridica // construtor e suas variaveis
    (int numero, string titular, double saldo, double emprestimoLimite)
    : base(numero, titular, saldo)
    {
        EmprestimoLimite = emprestimoLimite; 
    }
    public void Emprestimo(double saldoTotal) // método empréstimo com uma variavle interna Saldo Total
    {
        if (saldoTotal <= EmprestimoLimite) // condição
        {
            Saldo += saldoTotal;
        }
    }
}

