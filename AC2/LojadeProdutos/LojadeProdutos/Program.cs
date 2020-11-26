using System;
using System.Collections.Generic;


    public class MainProgram
    {

        static void Main(string[] args)
        {
        // instanciando as classes no main program \/\/\/
            ProdutoUsado produtoUsa = new ProdutoUsado();
            ProdutoImportado produtoImp = new ProdutoImportado();
            Produto produto = new Produto();
        // instanciando as classes no main program /\/\/\

            Console.WriteLine("Quantos produtos?: "); // pergunta para a quantidade de produtos
            produtoImp.quantidade = int.Parse(Console.ReadLine()); // quantidade de produtos que será guardada na memória e aplicada

            List<Produto> produtoLista = new List<Produto>(); // lista da classe produto + instanciando ela

            for (int i = 1; i <= produtoImp.quantidade; i++) // for principal para repetição das perguntas
            {
                Console.WriteLine("C/U/I");
                string cui = Console.ReadLine().ToLower(); // criação da variavel que detectará qual tipo de produto será ->
            // C - comum / U - Usado / I - Importado

                if(cui == "c") // se for o tipo comum...
                {
                Console.WriteLine("Nome do produto nº" + i + " :");
                produto.nome = Console.ReadLine(); // guardará o nome

                Console.WriteLine("Preco do produto nº" + i + " :");
                produto.preco = double.Parse(Console.ReadLine()); // guardará o preco

                produtoLista.Add(new Produto(produto.nome, produto.preco)); // adicionará na lista todas as informações -> nome e preco
            }
                if (cui == "u") // se for tipo usado...
                {
                Console.WriteLine("Nome do produto nº" + i + " :");
                produtoUsa.nome = Console.ReadLine(); // guardará o nome

                Console.WriteLine("Preco do produto nº" + i + " :");
                produtoUsa.preco = double.Parse(Console.ReadLine()); // guardará o preco

                Console.WriteLine("Data de Fabricação: ");
                produtoUsa.fabricacao = DateTime.Parse(Console.ReadLine()); // guardará a data de fabricação na classe produto usado

                produtoLista.Add(new ProdutoUsado(produtoUsa.nome, produtoUsa.preco, produtoUsa.fabricacao)); 
                // /\/\/\/\ aplicará os valores salvos na lista e instanciará dentro dela um novo produto usado, com os valores :
                // nome, preco e fabricação
            }
                if (cui == "i") // se for importado...
                {
                Console.WriteLine("Nome do produto nº" + i + " :");
                produtoImp.nome = Console.ReadLine(); // guardará o nome

                Console.WriteLine("Preco do produto nº" + i + " :");
                produtoImp.preco = double.Parse(Console.ReadLine()); // guardará o preco

                Console.WriteLine("Taxa: ");
                produtoImp.taxa = double.Parse(Console.ReadLine()); // guardará a taxa

                produtoLista.Add(new ProdutoImportado(produtoImp.nome, produtoImp.preco, produtoImp.taxa));
                // /\/\/\ aplicará todas essas variaveis na lista e instanciará dentro dela um novo produto importado com os valores:
                // nome, preco e taxa
                }

            }

            foreach(Produto produtos in produtoLista) // foreach para aplicar todas as informações atualizadas para o usuario
            {
            Console.WriteLine(produtos.precoTag()); // escreverá de acordo com a lista e mostrará no console
            }

        }
    }

