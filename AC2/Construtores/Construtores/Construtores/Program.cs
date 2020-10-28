using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Dados do produto ---");
            Console.Write("Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine("Digite o numero de produtos a ser adicionado: ");
            int quantia = int.Parse(Console.ReadLine());
            produto.AddProduto(quantia);

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("Digite o numero de produtos para serem removidos: ");
            quantia = int.Parse(Console.ReadLine());
            produto.RemoveProduto(quantia);

            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}
