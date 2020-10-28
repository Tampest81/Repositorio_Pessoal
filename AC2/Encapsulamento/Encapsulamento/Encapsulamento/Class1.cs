using System;

public class Produto
{
	private string Name;
	private double Preco;
	private int Quantidade;

		public Produto(string nome, double preco, int quantidade)
		{

		Name = nome;
		Preco = preco;
		quantidade = Quantidade;

		} 
		
	public double ValorTotalEstoque()
    {
		return Preco * Quantidade;
    }

	public void addProduto(int quantidade)
    {
		Quantidade = Quantidade + quantidade;
    }

	public void RemoveProduto(int quantidade)
    {
		Quantidade = Quantidade - quantidade;
    }

    public override string ToString()
    {
		return Name + "Preço: " + Preco + ", " + " Quantidade: " + Quantidade + ", "
		+ "Total: " + ValorTotalEstoque();
    }


}

