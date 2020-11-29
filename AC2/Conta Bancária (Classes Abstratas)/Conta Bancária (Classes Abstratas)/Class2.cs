using System;

class ContaPoupanca : Conta // herança conta
{
    public double TaxaJuros { get; set; } // criação da variavel Taxa juros com get set
    public ContaPoupanca() { } // contrutor
    public ContaPoupanca // construtor e seus valores
    (int numero, string titular, double saldo, double taxaJuros)
    : base(numero, titular, saldo)
    {
        TaxaJuros = taxaJuros;
    }
    public void atualizacaoSaldo() // metodo para atualizar o saldo
    {
        Saldo += Saldo * TaxaJuros;
    }
}
