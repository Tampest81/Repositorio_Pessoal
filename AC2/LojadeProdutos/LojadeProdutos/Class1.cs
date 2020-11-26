using System;

    public class ProdutoImportado : Produto // herança de classe
    {
        public ProdutoImportado() { } // construtor para o produto importado
        public double taxa { get; set; }  // variavel para a taxa
        public int quantidade { get; set; } // variavel para a quantidade de produtos
        
        public ProdutoImportado(string Nome, double Preco, double Taxa) : base(Nome,Preco) //construtor, recebendo de herança da classe produto
        {// ela recebe como herança as variaveis nome e preço
        taxa = Taxa;
        }

        public void precoTotal()
        {
            Console.WriteLine("TAXA: " + taxa);
        }

    public override string precoTag()
    {
        return "Nome: " + nome + " Preco: " + preco + " Taxa: " + taxa;
    }

}

