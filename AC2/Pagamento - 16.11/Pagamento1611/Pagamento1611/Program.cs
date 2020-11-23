using System;
using System.Collections.Generic;

namespace Pagamento1611
{
    public class Program
    {
        static List<funcionario> classe1; // criando a lista
        static void Main(string[] args)
        {
            int count = 0; // contador 

            funcionario classe = new funcionario(); // instanciando a classe funcionario
            terceiros classeTerc = new terceiros(); // instanciando a classe terceiros

            classe1 = new List<funcionario>(); // criando uma classe funcionario com o nome classe1

            Console.Write("Quantos funcionários?: ");
            int quantia = int.Parse(Console.ReadLine());// salva uma variavel, para ver quantas vezes o programa irá repetir

            while(count != quantia)
            {
                Console.Write("nome: ");
                classe.nome = Console.ReadLine();
                Console.Write("horas: ");
                classe.horas = int.Parse(Console.ReadLine());
                Console.Write("valor/hora: ");
                classe.valorHora = double.Parse(Console.ReadLine());

                classe.salariocalc(); // calculo do salario metodo

                Console.Write("funcionario de terceiros? S/N  :");
                classe.SN = Console.ReadLine().ToLower(); // para deixar sempre maiusculo o input do usuario
                if(classe.SN == "s")
                {
                    Console.Write("salario adicional em % : ");
                    classeTerc.adicional = double.Parse(Console.ReadLine());
                    classeTerc.porcentagem(); // calculo da porcentagem


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
