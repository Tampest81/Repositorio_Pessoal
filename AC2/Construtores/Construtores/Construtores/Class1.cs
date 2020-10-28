using System;
using System.Globalization;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }

    public void AddProduto(int quantidade)
    {
        Quantidade = Quantidade + quantidade;
    }

    public void RemoveProduto(int quantidade)
    {
        Quantidade = Quantidade - quantidade;
    }

    public override string ToString()
    {
        return Nome + ",R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
        + Quantidade + "unidade, Total: R$ " + ValorTotalEstoque().ToString
        ("F2", CultureInfo.InvariantCulture);

    }
}
