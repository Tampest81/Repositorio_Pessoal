using System;

    public abstract class Conta // conta principal Abstrata
    {
        public int Numero { get; private set; } // criaçao da variavel numero que será usada para identificação da conta
        public string Titular { get; private set; } // criação da variavel titular para nomear cada conta
        public double Saldo { get; protected set; } // criação da variavel saldo para guardar um valor
        public Conta() { } // construtor
        public Conta(int numero, string titular, double saldo) // construtor e suas variaveis
        {
            Numero = numero; Titular = titular; Saldo = saldo;
        }
        public void Saque(double saldoTotal) // método saque
        {
            Saldo -= saldoTotal;
        }
        public void Deposito(double saldoTotal) // método deposito
        {
            Saldo += saldoTotal;
        }
    }
