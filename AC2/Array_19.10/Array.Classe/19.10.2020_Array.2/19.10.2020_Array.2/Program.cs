using System;
using System.Numerics;

namespace _19._10._2020_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // variavel que decide o tamanho do array
            Console.Write("Quantidade de Produtos: ");
            double somaTotal = 0;
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            // array
            Produto[] vect = new Produto[n];
            // for para nomear e precificar cada produto, com o valor dependente de N
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome nº " + (i+1) + " : ");
                string name = Console.ReadLine();
                Console.Write("Valor do nº " + (i+1) + " : ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                vect[i] = new Produto { Name = name, Price = price };

                somaTotal = price + somaTotal;
            }
            // dados atualizados no final
            Console.WriteLine("");
            Console.WriteLine("Quantidade de Produtos: " + n);
            Console.WriteLine("Soma Total: " +somaTotal);
            Console.WriteLine("Média: " + (somaTotal/n));
        }
    }
}
