using System;
using System.Collections.Generic;
public class Produto 
{
	public Produto() { } // construtor
	public string nome { get; set; } // variavel nome
	public double preco { get; set; } // variavel preço

	public Produto(string Nome, double Preco) // construtor
    {
		nome = Nome;
		preco = Preco;
    }

	public virtual string precoTag() // método virtual
    {
		return "Nome: "+ nome + " Preco: " + preco;
	}

}
