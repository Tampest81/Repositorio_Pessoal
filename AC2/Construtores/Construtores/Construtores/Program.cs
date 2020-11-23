using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Dados do produto ---"); // dados do produto, adição de nome, quantidade e preço
            Console.Write("Produto: ");
            string nome = Console.ReadLine(); // salvará o nome do produto
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // salvará o valor do produto
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine()); // salvará a quantidade de produtos no estoque
            // instanciando as varaiveis da classe produto
            Produto produto = new Produto(nome, preco, quantidade);
            // metodo da classe produto Add produto para adicionar uma quantia ao total
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine("Digite o numero de produtos a ser adicionado: ");
            int quantia = int.Parse(Console.ReadLine()); // salvando a quantidade a ser adicionado no estoque
            produto.AddProduto(quantia); // chamando o método e pegando o valor dado e adicionando na variavel
            //mostrar os dados atualizados
            Console.WriteLine("Dados atualizados: " + produto);
            // metodo da classe produto remove produto para remover quantia
            Console.WriteLine("Digite o numero de produtos para serem removidos: ");
            quantia = int.Parse(Console.ReadLine()); // salvando a quantidade a ser removida do estoque
            produto.RemoveProduto(quantia); // chamando o método e pegando o valor dado e removendo na variavel
            // atualização dos dados depois dos metodos
            Console.WriteLine("Dados atualizados: " + produto); 

        }
    }
}
