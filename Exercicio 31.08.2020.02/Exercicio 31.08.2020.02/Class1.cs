using System;

namespace Exercicio_31._08._2020._02
{
	public class Valores
	{
		public string nome;
		public double preco;
		public int quantidade;

			public double ValorTotalEstoque()
			{
				double valorTotal = preco * quantidade;
				return valorTotal;
			}

			public void Espacamento()
        {
			Console.Write("  ");
			Console.WriteLine("  ");
        }
		
	}
}
