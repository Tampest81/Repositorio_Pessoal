using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Produtox", 1000, 20);

            Console.WriteLine(produto);
        }
    }
}
