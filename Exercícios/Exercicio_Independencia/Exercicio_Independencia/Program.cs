using System;
using System.Xml;

namespace Exercicio_Independencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("------------**------------");
            Console.WriteLine("Primeiro Exercicio");
            Console.WriteLine("------------**------------");
            Console.WriteLine("");

            Area x;

            x = new Area();
            
            Console.Write("Altura: ");
            x.altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            x.largura = double.Parse(Console.ReadLine());

            Console.WriteLine(x);

            //----------------------------*Exercicio 2*-----------------------------------
            Console.WriteLine("");
            Console.WriteLine("------------**------------");
            Console.WriteLine("Segundo Exercicio");
            Console.WriteLine("------------**------------");
            Console.WriteLine("");
            //----------------------------*Funcionario*-----------------------------------

            Funcionario ficha;

            ficha = new Funcionario();

            Console.Write("Nome do Funcionario: ");
            ficha.nome = Console.ReadLine();
            Console.Write("Salario do Funcionario: ");
            ficha.salario = double.Parse(Console.ReadLine());
            Console.Write("Digite um aumento do salario em porcentagem ");
            ficha.aumento = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            ficha.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(ficha);

            //----------------------------*Exercicio 3*-----------------------------------
            Console.WriteLine("");
            Console.WriteLine("------------**------------");
            Console.WriteLine("Terceiro Exercicio");
            Console.WriteLine("------------**------------");
            Console.WriteLine("");
            //----------------------------*Nota Da escola*-----------------------------------

            Notas nota, aluno;

            nota = new Notas();
            aluno = new Notas();

            Console.WriteLine("Nome do aluno: ");
            aluno.aluno = Console.ReadLine();

            Console.Write("Nota do primeiro Bimestre (Nota até 30 pontos): ");
            nota.nota1 = double.Parse(Console.ReadLine());
            while (nota.nota1 > 30 || nota.nota1 < 0)
            {
                Console.WriteLine("numero inválido, por favor digitar novamente, e conferir se o numero apresentado" +
                    " está entre 0-30");
                nota.nota1 = double.Parse(Console.ReadLine());
            }

            Console.Write("Nota do primeiro Bimestre (Nota até 35 pontos): ");
            nota.nota2 = double.Parse(Console.ReadLine());
            while (nota.nota2 > 35 || nota.nota2 < 0)
            {
                Console.WriteLine("numero inválido, por favor digitar novamente, e conferir se o numero apresentado" +
                    " está entre 0-35");
                nota.nota2 = double.Parse(Console.ReadLine());
            }

            Console.Write("Nota do primeiro Bimestre (Nota até 35 pontos): ");
            nota.nota3 = double.Parse(Console.ReadLine());
            while (nota.nota3 > 35 || nota.nota3 < 0)
            {
                Console.WriteLine("numero inválido, por favor digitar novamente, e conferir se o numero apresentado" +
                    " está entre 0-35");
                nota.nota3 = double.Parse(Console.ReadLine());
            }

            nota.Contador();

            //----------------------------*Exercicio 3*-----------------------------------
            Console.WriteLine("");
            Console.WriteLine("------------**------------");
            Console.WriteLine("Fim da lição do feriado");
            Console.WriteLine("------------**------------");
            Console.WriteLine("");
            //----------------------------*Nota Da escola*-----------------------------------



        }
    }
}
