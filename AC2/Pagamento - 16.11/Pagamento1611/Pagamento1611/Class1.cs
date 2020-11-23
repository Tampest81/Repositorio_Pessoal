using System;
using System.Collections.Generic;

namespace Pagamento1611
{
	public class funcionario : Program
	{
		public funcionario() { } // construtor
		public string nome { get; set; } // variavel para nome
		public int horas { get; set; }// variavel para as horas trabalhadas
		public double valorHora { get; set; } // variavel para o quanto a pessoa ganha por hora

		public double salario;// variavel para o salario

		public string SN; // variavel para o input do jogador selecionar se é tercerizado ou nao

		public funcionario(string nome, int horas, double valorHora, double salario) // construtor
		{
			this.nome = nome;
			this.horas = horas;
			this.valorHora = valorHora;

			salariocalc();

			this.salario = salario;	
        }

		public void Perguntas() // método para facilitar na hora da escrita
        {

			Console.WriteLine("nome: ");
			nome = Console.ReadLine();
			Console.WriteLine("horas: ");
			horas = int.Parse(Console.ReadLine());
			Console.WriteLine("Valor Hora: ");
			valorHora = double.Parse(Console.ReadLine());
        }

		public void salariocalc() // calculo do salario - metodo
        {
			salario = horas * valorHora; // o salario é as horas vezes o valor por hora

			if(SN == "s" || SN == "S")
            {
				terceiros terc = new terceiros(); // instanciando

				salario = salario * terc.adicional; // puxando a variavel da subclasse e aplicando
            }
		}

	}
}

