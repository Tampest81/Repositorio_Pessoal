using System;
using System.Collections.Generic;

namespace Pagamento1611
{
    public class Program
    {
        static List<funcionario> classe1;
        static void Main(string[] args)
        {
            int count = 0;

            funcionario classe = new funcionario();
            terceiros classeTerc = new terceiros();

            classe1 = new List<funcionario>();

            Console.Write("Quantos funcionários?: ");
            int quantia = int.Parse(Console.ReadLine());

            while(count != quantia)
            {
                Console.Write("nome: ");
                classe.nome = Console.ReadLine();
                Console.Write("horas: ");
                classe.horas = int.Parse(Console.ReadLine());
                Console.Write("valor/hora: ");
                classe.valorHora = double.Parse(Console.ReadLine());

                classe.salariocalc();

                Console.Write("funcionario de terceiros? S/N  :");
                classe.SN = Console.ReadLine().ToLower();
                if(classe.SN == "s")
                {
                    Console.Write("salario adicional em % : ");
                    classeTerc.adicional = double.Parse(Console.ReadLine());
                    classeTerc.porcentagem();


                    Console.WriteLine(classeTerc.adicional * classe.salario);

                    classe.salario = classe.salario * classeTerc.adicional;
                }
                else
                {
                    classe.salariocalc();
                }


                classe1.Add(new funcionario(classe.nome, classe.horas, classe.valorHora, classe.salario));

                count++;
            }

            foreach (funcionario func in classe1)
            {
                Console.WriteLine("Nome: " + func.nome +" || Horas: "+ func.horas +" || Valor/Hora: "+ func.valorHora + " || Salário: " + func.salario);
            }


        }
    }
}
