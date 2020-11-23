using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Produtox", 1000, 20); // instanciando a variavel da classe com suas variaveis

            Console.WriteLine(produto); // irá escrever o tostring para receber a atualização final
        }
    }
}
