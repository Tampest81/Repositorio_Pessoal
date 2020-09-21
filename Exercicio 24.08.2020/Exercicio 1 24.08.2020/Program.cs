using System;

namespace Exercicio_1_24._08._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Valor pessoa1, pessoa2;

            pessoa1 = new Valor();
            pessoa2 = new Valor();

            float mediaSalarial;
            float diferencial;

            Console.Write("Nome1: ");
                pessoa1.pessoa = Console.ReadLine();
            Console.Write("Idade1: ");
                pessoa1.idade = float.Parse(Console.ReadLine());
            Console.Write("Salário1: ");
                pessoa1.salario = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Nome2: ");
                pessoa2.pessoa = Console.ReadLine();
            Console.Write("Idade2: ");
                pessoa2.idade = float.Parse(Console.ReadLine());
            Console.Write("Salário2: ");
                pessoa2.salario = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            if (pessoa1.idade > pessoa2.idade)
            {
                diferencial = pessoa1.idade - pessoa2.idade;
                Console.WriteLine(pessoa1.idade + " é mais velho que " + pessoa2.idade + " por " + diferencial + " anos.");
            }
            else
            {
                diferencial = pessoa2.idade - pessoa1.idade;
                Console.WriteLine(pessoa2.idade + " é mais velho que " + pessoa1.idade + " por " + diferencial + " anos.");
            }

            Console.WriteLine(" ");

            mediaSalarial = (pessoa1.salario + pessoa2.salario) / 2;
            Console.WriteLine("A média salarial é : " + mediaSalarial);


            Console.ReadKey();
        }


    }
}
