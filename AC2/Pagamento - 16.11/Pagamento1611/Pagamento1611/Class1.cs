using System;
using System.Collections.Generic;

namespace Pagamento1611
{
	public class funcionario : Program
	{
		public funcionario() { }
		public string nome { get; set; }
		public int horas { get; set; }
		public double valorHora { get; set; }

		public double salario;

		public string SN;

		public funcionario(string nome, int horas, double valorHora, double salario)
		{
			this.nome = nome;
			this.horas = horas;
			this.valorHora = valorHora;

			salariocalc();

			this.salario = salario;	
        }

		public void Perguntas()
        {

			Console.WriteLine("nome: ");
			nome = Console.ReadLine();
			Console.WriteLine("horas: ");
			horas = int.Parse(Console.ReadLine());
			Console.WriteLine("Valor Hora: ");
			valorHora = double.Parse(Console.ReadLine());
        }

		public void salariocalc()
        {
			salario = horas * valorHora;

			if(SN == "s" || SN == "S")
            {
				terceiros terc = new terceiros();

				salario = salario * terc.adicional;
            }
		}

	}
}

