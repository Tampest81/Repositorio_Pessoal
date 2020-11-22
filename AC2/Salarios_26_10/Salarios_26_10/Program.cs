using System;
using System.Collections.Generic;

namespace Salarios_26_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Info> info;

            Info info_ = new Info();

            info = new List<Info>();

            int counter = 0;

            Console.Write("Quantos funcionários? : ");
            int QntFuncionarios = int.Parse(Console.ReadLine());

            var numbers = new List<int>();

            while(counter != QntFuncionarios)
            {
                Console.Write("ID: ");
                info_.ID = int.Parse(Console.ReadLine());

                while (info.FindAll(x=>x.ID == info_.ID).Count>0)
                {
                    Console.WriteLine("Outro: ");
                    info_.ID = int.Parse(Console.ReadLine());
                }

                Console.Write("Nome: ");
                info_.nome = Console.ReadLine();
                Console.Write("Salario: ");
                info_.salario = double.Parse(Console.ReadLine());

                info.Add(new Info(info_.ID, info_.nome, info_.salario));

                Console.WriteLine("______________________________________");

                counter++;

            }

            foreach(Info inf in info)
            {
                Console.WriteLine("ID> "      + inf.ID   + "  " +
                                  "Nome> "    + inf.nome + "  " +
                                  "Salario> " + inf.salario);

                Console.WriteLine("______________________________________");
            }

            Console.WriteLine("Id do funcinário que irá receber aumento:");
            int id = int.Parse(Console.ReadLine());

            Info finder = info.Find(x => x.ID == id);

            if (finder != null && id == finder.ID)
            {
                Console.Write("Quantidade (em %) de salario a ser aumentada :");
                info_.porcentagem = float.Parse(Console.ReadLine());

                info_.porcentagem = ((info_.porcentagem / 100)+1);

                Info salaryFinder = info.Find(info_ => info_.salario == id);

                salaryFinder.salario = salaryFinder.salario * info_.porcentagem;
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
