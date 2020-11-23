using System;
using System.Collections.Generic;

namespace Salarios_26_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Info> info; // criação da lista de uma classe

            Info info_ = new Info(); // instanciando a classe no programa (objeto)

            info = new List<Info>(); // instanciando a lista

            int counter = 0; // contador

            Console.Write("Quantos funcionários? : ");
            int QntFuncionarios = int.Parse(Console.ReadLine()); // salvará a quantidade de funcionarios 

            var numbers = new List<int>();

            while(counter != QntFuncionarios) // while para repetir e pedir o input do usuario para por as informações dos funcionarios
            {
                Console.Write("ID: ");
                info_.ID = int.Parse(Console.ReadLine()); // salvará o id do funcionario na lista

                while (info.FindAll(x=>x.ID == info_.ID).Count>0) // verificará numa lista criada se já possui o id
                {
                    Console.WriteLine("Outro: ");
                    info_.ID = int.Parse(Console.ReadLine()); // se possuir o sistema pede outro
                }

                Console.Write("Nome: ");
                info_.nome = Console.ReadLine(); // salva o nome na lista
                Console.Write("Salario: ");
                info_.salario = double.Parse(Console.ReadLine()); // salva o salario na lista

                info.Add(new Info(info_.ID, info_.nome, info_.salario)); // salva as informações gerais na lista e em suas variaveis

                Console.WriteLine("______________________________________");

                counter++;

            }

            foreach(Info inf in info) // atualiza as informações mostrando todos os dados
            {
                Console.WriteLine("ID> "      + inf.ID   + "  " +
                                  "Nome> "    + inf.nome + "  " +
                                  "Salario> " + inf.salario);

                Console.WriteLine("______________________________________");
            }

            Console.WriteLine("Id do funcinário que irá receber aumento:");
            int id = int.Parse(Console.ReadLine()); // id do funcionario q recebera aumento

            Info finder = info.Find(x => x.ID == id); // irá encontrar o id

            if (finder != null && id == finder.ID) // irá verificar se o id existe e aplicar se for igual
            {
                Console.Write("Quantidade (em %) de salario a ser aumentada :");
                info_.porcentagem = float.Parse(Console.ReadLine()); // porcentagem que o usuario irá inputar

                info_.porcentagem = ((info_.porcentagem / 100)+1); // calculo para a porcentagem

                Info salaryFinder = info.Find(info_ => info_.salario == id); // procura o salario

                salaryFinder.salario = salaryFinder.salario * info_.porcentagem; // aplica o salario encontrado com o id e aplica o novo valor
            }

            else
            {
                Console.WriteLine("Não existe");
            }



            foreach (Info inf in info)
            {

                Console.WriteLine("______________________________________");

                Console.WriteLine("Dados Atualizados: ");
                Console.WriteLine(" ");
                Console.WriteLine("ID> " + inf.ID + "  " +
                                  "Nome> " + inf.nome + "  " +
                                  "Salario> " + inf.salario);

                Console.WriteLine("______________________________________");
            }


            Console.ReadKey();
        }
    }
}
