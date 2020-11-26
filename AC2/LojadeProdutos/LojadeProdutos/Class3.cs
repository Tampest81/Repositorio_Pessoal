using System;

// classe produto Usado
public class ProdutoUsado:Produto // herança 
{
    public ProdutoUsado() { }  // construtor
    public DateTime fabricacao { get; set; } // variavel para poder colocar a data de fabricação

    public ProdutoUsado(string Nome, double Preco, DateTime Fabricacao) : base(Nome, Preco) // construtor, recebe como herança
    {// continuação -> recebe como herança as variaveis nome e preco da classe produto
        fabricacao = Fabricacao;
    }
    public override string precoTag() // método feito com override para o polimorfismo
    {
        return "Nome: " + nome + " Preco: " + preco + " Fabricação: " + fabricacao;
    } // escreverá, o nome do produto o preço, e a data de fabricação, o método retornará uma string
}
