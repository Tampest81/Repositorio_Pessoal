using System;

namespace Exercicio_31._08._2020._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Valores produto;

            produto = new Valores();

                Console.Write("Nome do Produto: ");
                produto.nome = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                produto.preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade do Produto no Estoque: ");
                produto.quantidade = int.Parse(Console.ReadLine());

            produto.Espacamento();

                Console.WriteLine("Dados do produto: " 
                    + produto.nome + ", Valor total: "
                    + produto.ValorTotalEstoque() + " Reais, " 
                    + produto.quantidade);

            produto.Espacamento();

                Console.Write("Digite a quantidade para ser ADICIONADO no ESTOQUE: ");
                int valorAdicional = int.Parse(Console.ReadLine());

                        produto.quantidade = valorAdicional + produto.quantidade;

            produto.Espacamento();

                Console.WriteLine("Dados do produto atualizados: " 
                    + produto.nome + ", Valor total: " 
                    + produto.ValorTotalEstoque() + " Reais, " 
                    + produto.quantidade);

            produto.Espacamento();

                Console.Write("Digite a quantidade para ser REMOVIDO no ESTOQUE: ");
                valorAdicional = int.Parse(Console.ReadLine());

            produto.quantidade = produto.quantidade - valorAdicional ;

            produto.Espacamento();

                Console.WriteLine("Dados do produto atualizados: " 
                    + produto.nome + ", Valor total: " 
                    + produto.ValorTotalEstoque() + " Reais, "
                    + produto.quantidade);


            Console.ReadLine();
        }

    }
}
